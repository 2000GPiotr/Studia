using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1._2._3
{
    
    public partial class Form1 : Form
    {
        static int radius = 200;
        static Font textFont = new Font("Century", 12F);
        static SolidBrush liczbyKolor = new SolidBrush(Color.FromArgb(10, 10, 10));
        static int stopnie = 360 / 12;
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        public float obliczX(float stopnie, float r)
        {
            return (float)(r * Math.Cos((Math.PI / 180) * stopnie));
        }

        public float obliczY(float stopnie, float r)
        {
            return (float)(r * Math.Sin((Math.PI / 180) * stopnie));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            Rectangle rect = new Rectangle(-radius-15, -radius-15, 2*radius + 30, 2*radius + 30 );

            var srWidth = this.ClientSize.Width / 2;
            var srHeight = this.ClientSize.Height / 2;
            e.Graphics.TranslateTransform(srWidth, srHeight);

            e.Graphics.DrawEllipse(Pens.Black, rect);

            for (int i = 1; i <= 12; i++)
            {
                e.Graphics.DrawString(i.ToString(), textFont, liczbyKolor, -1 * obliczX(i * stopnie + 90, radius) + 1, -1 * obliczY(i * stopnie + 90, radius) + 2, format);
            }
           // System.Console.Beep();
            var time = DateTime.Now;
            var hour = time.Hour;
            var minutes = time.Minute;
            var seconds = time.Second;

            var godzinyTic = 2.0 * Math.PI * (hour + minutes  / 60.0 + seconds / 360) / 12.0;
            
            Point pktSrodek = new Point(0, 0);
            Point pktWskGodzina = new Point((int)(radius*0.7 * Math.Sin(godzinyTic)), (int)(-(radius*0.7) * Math.Cos(godzinyTic)));
            e.Graphics.DrawLine(Pens.Black, pktSrodek, pktWskGodzina);

            var minutyTic = 2.0 * Math.PI * (minutes + seconds / 60.0) / 60.0;

            Point pktWskMinuta = new Point((int)(radius*0.9 * Math.Sin(minutyTic)), (int)(-(radius*0.9) * Math.Cos(minutyTic)));
            e.Graphics.DrawLine(Pens.Gray, pktSrodek, pktWskMinuta);

            var sekundyTic = 2.0 * Math.PI * (seconds) / 60.0;

            Point pktWskSekunda = new Point((int)(radius * Math.Sin(sekundyTic)), (int)(-(radius) * Math.Cos(sekundyTic)));
            e.Graphics.DrawLine(Pens.Red, pktSrodek, pktWskSekunda);
        }
    }
}
