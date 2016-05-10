using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// images: source, resized, grayscaled, avg-grayscaled

namespace MTGWiz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close all windows here?
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //open the file dialog button here
            DialogResult dialogResult = openFileDialog.ShowDialog();

            //picked something incorrect or cancels
            if (dialogResult != DialogResult.OK || openFileDialog.FileName.Equals(""))
            {
                openFileLabel.Text = "file not found";
                return;
            }

            openFileLabel.Text = openFileDialog.FileName;
            ProcessAndUpdateUI(openFileDialog.FileName);
        }

        private void ProcessAndUpdateUI(string fileName)
        {
            //open source image
            Image<Bgr, Byte> source = new Image<Bgr, Byte>(fileName);

            //resize
            Image<Bgr, Byte> resized = source.Resize(32, 32, Emgu.CV.CvEnum.Inter.Linear);

            //grayscale
            Image<Gray, Byte> grayscaled = resized.Convert<Gray, Byte>();
            int sum = 0;
            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    sum += grayscaled.Data[x, y, 0];
                }
            }

            //update UI
            sourceImageBox.Image = source;
            resizeImageBox.Image = resized;
            grayImageBox.Image = grayscaled;
        }
    }
}
