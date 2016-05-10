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

        public Result HashImage()
        {
            return null;
        }


        public class Result
        {
            string hash;
            Image<Bgr, byte> source;
            Image<Gray, byte> gray;
            Image<Gray, byte> avg;
            
        }
    }
}
