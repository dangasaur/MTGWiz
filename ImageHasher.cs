using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

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
            //open source image
            Image<Bgr, Byte> source = new Image<Bgr, Byte>(path);

            //resize
            Image<Bgr, Byte> resized = source.Resize(8, 8, Emgu.CV.CvEnum.Inter.Linear);

            //grayscale
            Image<Gray, Byte> grayscaled = resized.Convert<Gray, Byte>();

            //threshold
            uint avg = AvgValue(grayscaled);
            Image<Gray, byte> thresholded = grayscaled.ThresholdBinary(new Gray(avg), new Gray(255));

            //compute hash string
                //flatten the thresholded image to a one dimensional array
                //convert the array into a hex string
            uint dec = 0;


            return new HashResult("", source, resized, grayscaled, thresholded);
        }

    }
}
