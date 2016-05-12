using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace MTGWiz
{
    class ImageHasher
    {
        const uint HASH_SIZE = 8;

        private uint AvgValue(Image<Gray, byte> image)
        {
            uint sum = 0;
            for (int y = 0; y < HASH_SIZE; y++)
            {
                for (int x = 0; x < HASH_SIZE; x++)
                {
                    sum += image.Data[x, y, 0];
                }
            }

            return sum / (HASH_SIZE * HASH_SIZE);
        }

        public HashResult HashImage(string path)
        {
            //source, resize, grayscale, threshold
            Image<Bgr, Byte> source = new Image<Bgr, Byte>(path);
            Image<Bgr, Byte> resized = source.Resize(8, 8, Emgu.CV.CvEnum.Inter.Linear);
            Image<Gray, Byte> grayscaled = resized.Convert<Gray, Byte>();
            uint avg = AvgValue(grayscaled);
            Image<Gray, byte> thresholded = grayscaled.ThresholdBinary(new Gray(avg), new Gray(255));

            //compute hash
            List<Boolean> flatBoolImage = new List<Boolean>();
            for (int y = 0; y < HASH_SIZE; y++)
            {
                for (int x = 0; x < HASH_SIZE; x++)
                {
                    flatBoolImage.Add(thresholded.Data[x, y, 0] == 0);
                }
            }

            StringBuilder hashStringBuilder = new StringBuilder();
            int dec = 0;
            foreach (var it in flatBoolImage.Select((value, index) => new { Value = value, Index = index }) )
            {
                if (it.Value)
                {
                    dec += 2 ^ (it.Index % 8);
                }

                if (it.Index %8 == 7)
                {
                    hashStringBuilder.Append(dec.ToString("X2"));
                    dec = 0;
                }
            }

            Debug.WriteLine("hash: " + hashStringBuilder.ToString());

            return new HashResult(hashStringBuilder.ToString(), source, resized, grayscaled, thresholded);
        }

    }
}
