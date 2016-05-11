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
        private string hash;
        private Image<Bgr, Byte> source;
        private Image<Bgr, Byte> resize;
        private Image<Gray, Byte> grayscale;
        private Image<Gray, Byte> threshold;
        
        public string Hash {
            get { return this.hash; }
        }

        public Image<Bgr, Byte> Source
        {
            get { return this.source; }
        }

        public Image<Bgr, Byte> Resize
        {
            get { return this.resize; }
        }

        public Image<Gray, Byte> Grayscale
        {
            get { return this.grayscale; }
        }

        public Image<Gray, Byte> Threshold
        {
            get { return this.threshold; }
        }

        public HashResult(string hash, Image<Bgr, byte> source, Image<Bgr, Byte> resize, Image<Gray, Byte> grayscale, Image<Gray, Byte> threshold)
        {
            this.hash = hash;
            this.source = source;
            this.resize = resize;
            this.grayscale = grayscale;
            this.threshold = threshold;
        }
    }
}
