using System.Reflection.Metadata;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] segmentPoints = new Point[]
            {
            new Point(25, 10),
            new Point(55, 10),
            new Point(61, 16),
            new Point(55, 22),
            new Point(25, 22),
            new Point(19, 16)
            };

            g.FillPolygon(Brushes.Red, segmentPoints);
            g.DrawPolygon(Pens.Red, segmentPoints);
            Point[] segmentPoints2 = new Point[]
            {
            new Point(57, 23),
            new Point(63,17),
            new Point(69, 23),
            new Point(69, 53),
            new Point(63, 59),
            new Point(57, 53)
            };
            g.FillPolygon(Brushes.Red, segmentPoints2);
            g.DrawPolygon(Pens.Red, segmentPoints2);

            Point[] segmentPoints3 = new Point[]
{
            new Point(25, 54),
            new Point(55, 54),
            new Point(61, 60),
            new Point(55, 66),
            new Point(25, 66),
            new Point(19, 60)
};
            g.FillPolygon(Brushes.Red, segmentPoints3);
            g.DrawPolygon(Pens.Red, segmentPoints3);

            Point[] segmentPoints4 = new Point[]
            {
            new Point(11, 23),
            new Point(17,17),
            new Point(23, 23),
            new Point(23, 53),
            new Point(17, 59),
            new Point(11, 53)
            };
            g.FillPolygon(Brushes.Red, segmentPoints4);
            g.DrawPolygon(Pens.Red, segmentPoints4);


            Point[] segmentPoints5 = new Point[]
            {
            new Point(57, 23+44),
            new Point(63,17+44),
            new Point(69, 23+44),
            new Point(69, 53 + 44),
            new Point(63, 59 + 44),
            new Point(57, 53 + 44)
            };
            g.FillPolygon(Brushes.Red, segmentPoints5);
            g.DrawPolygon(Pens.Red, segmentPoints5);

            Point[] segmentPoints6 = new Point[]
{
            new Point(25, 54+44),
            new Point(55, 54+44),
            new Point(61, 60+44),
            new Point(55, 66+44),
            new Point(25, 66+44),
            new Point(19, 60+44)
};
            g.FillPolygon(Brushes.Red, segmentPoints6);
            g.DrawPolygon(Pens.Red, segmentPoints6);

            Point[] segmentPoints7 = new Point[]
            {
            new Point(11, 23+44),
            new Point(17,17+44),
            new Point(23, 23+44),
            new Point(23, 53+44),
            new Point(17, 59+44),
            new Point(11, 53+44)
            };
            g.FillPolygon(Brushes.Red, segmentPoints7);
            g.DrawPolygon(Pens.Red, segmentPoints7);

        }

        private void ucLed1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ucLedBoard1.LedCount = (int)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucLedBoard1.DisplayText = (string)textBox1.Text;
        }
    }
}