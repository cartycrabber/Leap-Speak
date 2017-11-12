using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teach_asl_cs
{
    public partial class Form1 : Form
    {
        string[] symbolImages = new string[0];
        int symbolIndex = 3;

        public Form1()
        {
            InitializeComponent();
            SetupSlideShow();
        }

        private void SetupSlideShow()
        {
            symbolImages = Directory.GetFiles("assets");
            Array.Sort(symbolImages);
            UpdateImage();
        }

        private void UpdateImage()
        {
            if (symbolIndex < symbolImages.Length && symbolIndex >= 0)
            {
                pictureBox.ImageLocation = symbolImages[symbolIndex];
            }
        }

        private void nextSymbol_Click(object sender, EventArgs e)
        {
            ++symbolIndex;
            symbolIndex = symbolIndex % symbolImages.Length;
            UpdateImage();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            --symbolIndex;
            if (symbolIndex < 0)
            {
                symbolIndex = symbolImages.Length - 1;
            }
            UpdateImage();
        }
    }
}
