using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using Emgu.CV;

namespace MTGWiz
{
    class HashResult
    {
        string hash { get; set; }
        Image<Bgr, byte> source { get; set; }
        Image<Bgr, Byte> resize { get; set; }
        Image<Gray, Byte> grayscale { get; set; }
    }
}
