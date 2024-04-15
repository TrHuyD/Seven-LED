using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ucLedBoard : UserControl
    {
        private int ledCount = 5;
        private string displayText = "";
        public ucLedBoard()
        {
            InitializeComponent();
            ResizeLedBoard();
        }
        public string DisplayText
        {
            get { return displayText;  }
            set
            {
                if (value == displayText)
                    return;
                else
                {
                    displayText = value;
                    updateLedBoard();
                }
            
            }
        }
        public int LedCount
        {
            get { return ledCount; }
            set
            {
                if (value > 0)
                {
                    ledCount = value;
                    ResizeLedBoard();
                    updateLedBoard();
                }
            }
        }
        private void updateLedBoard()
        {
            List<char> texts = new List<char>();
            List<bool> commas = new List<bool>();


            bool prevWasComma = true;
            char tempo = '\0';
            foreach (char c in displayText)
            {
                // Check if the current character is a comma and the previous character was not a comma
                if (c == '.')
                {
                    if (prevWasComma)
                    {
                        texts.Add(' ');
                        commas.Add(true);
                    }
                    else
                    {
                        texts.Add(tempo);
                        commas.Add(true);
                        tempo = '\0';
                    }
                }
                else
                {
                    if (tempo != '\0')
                    {
                        texts.Add(tempo);
                        commas.Add(false);
                    }
                    tempo = c;

                }

                // Update the flag for the previous character
                prevWasComma = (c == '.');
            }
            if (tempo != '\0')
            {
                texts.Add(tempo);
                commas.Add(false);
            }
            int size = Math.Min(texts.Count, flowLayoutPanel1.Controls.Count);
            for (int i = 0; i < size; i++)
            {
                ((ucLed)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - size + i]).DisplayValue(texts[i], commas[i]);
            }
            for (int i = flowLayoutPanel1.Controls.Count - size - 1; i >= 0; i--)
            {
                ((ucLed)flowLayoutPanel1.Controls[i]).DisplayValue(' ', false);
            }
        }
        private void ResizeLedBoard()
        {
            int ledWidth = ucLed.DefaultSize.Width;
            int ledHeight = ucLed.DefaultSize.Height;

            int panelWidth = ledWidth * ledCount;
            int panelHeight = ledHeight;

            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < ledCount; i++)
            {
                ucLed led = new ucLed(); 
                led.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(led); 
            }

            flowLayoutPanel1.Padding = new Padding(0); 
            flowLayoutPanel1.Size = new Size(panelWidth, panelHeight);
            this.Size = new Size(panelWidth, panelHeight);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            int ledWidth = ucLed.DefaultSize.Width;
            int ledHeight = ucLed.DefaultSize.Height;
            int panelWidth = ledWidth * ledCount;
            int panelHeight = ledHeight;
            this.Size = new Size(panelWidth, panelHeight);
        }
    }
}