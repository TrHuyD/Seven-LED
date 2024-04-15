using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class ucLed : UserControl
    {
        private char display_text = ' ';
        private bool display_comma=false;
        public char DisplayText
        {
            get { return display_text; }
            set
            {
                display_text = value;

            }
        }
        public bool DisplayComma
        {
            get { return display_comma; }
            set
            { display_comma = value; }
        }
        public void DisplayValue(char _value,bool comma)
        {
            if(display_text== _value&& display_comma==comma) { return; }
            DisplayText = _value;
            DisplayComma = comma;
            panel1.Invalidate();
        }
        public static Size DefaultSize { get; } = new Size(81, 111); 

        private static readonly Dictionary<char, string> SegmentMappings = new Dictionary<char, string>()
    {
    {' ', "0000000"},
    {'0', "1111110"},
    {'1', "0110000"},
    {'2', "1101101"},
    {'3', "1111001"},
    {'4', "0110011"},
    {'5', "1011011"},
    {'6', "1011111"},
    {'7', "1110000"},
    {'8', "1111111"},
    {'9', "1111011"},
    {'A', "1110111"},
    {'B', "0011111"},
    {'C', "1001110"},
    {'D', "0111101"},
    {'E', "1001111"},
    {'F', "1000111"},
    {'G', "1011110"},
    {'H', "0110111"},
    {'I', "0000110"},
    {'J', "0111100"},
    {'K', "0110111"},
    {'L', "0001110"},
    {'M', "1101010"},
    {'N', "0010101"},
    {'O', "1111110"},
    {'P', "1100111"},
    {'Q', "1110011"},
    {'R', "0000101"},
    {'S', "1011011"},
    {'T', "1001110"},
    {'U', "0111110"},
    {'V', "0111110"},
    {'W', "0111110"},
    {'X', "0110111"},
    {'Y', "0111011"},
    {'Z', "1101101"}

    };
        public static string MapCharacter(char c)
        {
            if (SegmentMappings.ContainsKey(c))
            {
                return SegmentMappings[c];
            }
            else
            {
                return "0000000"; 
            }
        }

        public ucLed()
        {
            InitializeComponent();
            
        }
        public static void DrawSegments(Graphics g, string segments,bool _comma=false)
        {
            if (segments.Length != 7)
            {
                throw new ArgumentException("The length of segments must be 7.");
            }

            Point[][] segmentPoints = new Point[][]
            {
            new Point[]
            {
                new Point(25, 5),
                new Point(55, 5),
                new Point(61, 11),
                new Point(55, 17),
                new Point(25, 17),
                new Point(19, 11)
            },
            new Point[]
            {
                new Point(57, 18),
                new Point(63, 12),
                new Point(69, 18),
                new Point(69, 54),
                new Point(63, 54),
                new Point(57, 48)
            },


            new Point[]
            {
                new Point(57, 18 + 44),
                new Point(63, 12 + 44),
                new Point(69, 12 + 44),
                new Point(69, 48 + 44),
                new Point(63, 54 + 44),
                new Point(57, 48 + 44)
            },
            new Point[]
            {
                new Point(25, 49 + 44),
                new Point(55, 49 + 44),
                new Point(61, 55 + 44),
                new Point(55, 61 + 44),
                new Point(25, 61 + 44),
                new Point(19, 55 + 44)
            },
            new Point[]
            {
                new Point(11, 12 + 44),
                new Point(17, 12 + 44),
                new Point(23, 18 + 44),
                new Point(23, 48 + 44),
                new Point(17, 54 + 44),
                new Point(11, 48 + 44)
            },
                        new Point[]
            {
                new Point(11, 18),
                new Point(17, 12),
                new Point(23, 18),
                new Point(23, 48),
                new Point(17, 54),
                new Point(11, 54)
            },
            new Point[]
            {
                new Point(25, 49),
                new Point(55, 49),
                new Point(61, 55),
                new Point(55, 61),
                new Point(25, 61),
                new Point(19, 55)
            }
            };

            for (int i = 0; i < segments.Length; i++)
            {
                if (segments[i] == '1')
                {
                    g.FillPolygon(Brushes.Red, segmentPoints[i]);
                    g.DrawPolygon(Pens.Red, segmentPoints[i]);
                }
                else if (segments[i] == '0')
                {
                    g.FillPolygon(Brushes.DarkRed, segmentPoints[i]);
                    g.DrawPolygon(Pens.DarkRed, segmentPoints[i]);
                }
                else
                {
                    throw new ArgumentException("Invalid segment value. Must be '0' or '1'.");
                }
            }
            if(_comma)
            {
                g.DrawEllipse(Pens.Red, 69, 95, 10, 10);
                g.FillEllipse(Brushes.Red, 69, 95, 10, 10);
            }    
            else
            {
                g.DrawEllipse(Pens.DarkRed, 69, 95, 10, 10);
                g.FillEllipse(Brushes.DarkRed, 69, 95, 10, 10);
            }    

        }
        private Graphics _g;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            DrawSegments(e.Graphics, MapCharacter(DisplayText), DisplayComma); // Assuming only one character for simplicity
        }
    }
}
