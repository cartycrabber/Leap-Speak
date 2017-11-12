using Leap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachAslCsharp
{
    public partial class Form1 : Form
    {
        const int SUCCESS_DELAY = 2;

        // slideshow variables
        private string[] symbolImages = new string[0];
        private int symbolIndex = 0;

        private SymbolMapping symbolMapping = SymbolMapping.GetInstance();
        private int desiredSymbol = -1;
        private DateTime lastUndesiredSymbol = DateTime.Now;

        public delegate void SymbolReceiver(int symbol_id);
        private SymbolReceiver readSymbol;
        private HandListener handListener;
        private Controller leapController;

        private int symbolCount = 0;
        private delegate void labelSetter(string text);
        private labelSetter setStatusWrapper;
        private labelSetter setDetectedWrapper;

        public Form1()
        {
            InitializeComponent();
            SetupSlideShow();
            SetupSymbolList();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            readSymbol += SymbolReceived;
            setStatusWrapper += SetStatusText;
            setDetectedWrapper += SetDetectedText;

            handListener = new HandListener(readSymbol);
            leapController = new Controller();
            leapController.AddListener(handListener);
        }

        private void SetupSlideShow()
        {
            symbolImages = Directory.GetFiles("assets");
            Array.Sort(symbolImages);
            UpdateImage();
        }

        private void SetupSymbolList()
        {
            foreach (string symbol in symbolMapping.AllSymbols())
            {
                symbolList.Items.Add(symbol);
            }
        }

        private void UpdateImage()
        {
            if (symbolIndex < symbolImages.Length && symbolIndex >= 0)
            {
                pictureBox.ImageLocation = symbolImages[symbolIndex];
            }
        }

        private void SetStatusText(string status)
        {
            statusLabel.Text = status;
        }

        private void SetDetectedText(string detected)
        {
            detectedLabel.Text = detected;
        }

        private void SymbolReceived(int symbol_id)
        {
            ++symbolCount;
            Debug.WriteLine("Symbol: " + symbolMapping.GetId(symbol_id) + " " + symbolCount.ToString());

            if (symbol_id != desiredSymbol)
            {
                lastUndesiredSymbol = DateTime.Now;
            }
            else if (DateTime.Now.Subtract(lastUndesiredSymbol).Seconds > SUCCESS_DELAY)
            {
                Invoke(setStatusWrapper, "You got it right!");
            }
            else
            {
                Invoke(setStatusWrapper, "Hold it...");
            }

            Invoke(setDetectedWrapper, "Detected Symbol: " + symbolMapping.GetId(symbol_id));
        }

        private void Form1_Resize(object Sender, EventArgs e)
        {
            //Size size = learnPage.ClientSize;
            //float h_scale = (float)size.Width / (float)pictureBox.Image.Width;
            //float v_scale = (float)(size.Height - previousButton.Height) / (float)pictureBox.Image.Height;
            //h_scale = Math.Min(h_scale, v_scale);

            //pictureBox.Scale(new SizeF(h_scale, h_scale));
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

        private void symbolList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (symbolList.Focused || randomButton.Focused)
            {
                symbolSearch.Text = symbolList.SelectedItem.ToString();
                desiredSymbol = symbolMapping.GetName(symbolSearch.Text);
            }
            SetStatusText("Searching for " + symbolList.SelectedItem.ToString() + "...");
        }

        private void symbolSearch_TextChanged(object sender, EventArgs e)
        {
            if (!symbolSearch.Focused)
            {
                // this'll happen when a symbol is selected from the list
                return;
            }

            symbolList.Items.Clear();
            foreach (string filtered in symbolMapping.AllSymbols().Where(s => s.ToLower().Contains(symbolSearch.Text)))
            {
                symbolList.Items.Add(filtered);
            }
            if (symbolList.Items.Count > 0)
            {
                symbolList.SelectedIndex = 0;
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            symbolSearch.Text = ""; // triggers a re-filter of filter list, sadly
            symbolList.Items.Clear();
            foreach (string symbol in symbolMapping.AllSymbols())
            {
                symbolList.Items.Add(symbol);
            }

            Random rand = new Random();
            symbolList.SelectedIndex = rand.Next() % symbolList.Items.Count;
        }
    }
}
