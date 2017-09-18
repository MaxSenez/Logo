using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Logoform : Form
    {
        public Logoform()
        {
            InitializeComponent(); //
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            //Setup
           
            //Outlines
            Pen drawredPen = new Pen(Color.IndianRed, 7);
            Pen drawwhtPen = new Pen(Color.White, 1);
           
            //Fonts
            Font drawlargeFont = new Font("Magneto", 72, FontStyle.Bold);
            Font drawsmallFont = new Font("Magneto", 36, FontStyle.Bold);
            Font drawtinyFont = new Font("High Tower Text", 8, FontStyle.Regular);
            
            //Fillers
            SolidBrush darkGreenBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush LightGreenBrush = new SolidBrush(Color.LightGreen);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);

            //Creating Graphics
            formGraphics.DrawArc(drawredPen, 60, 20, 202, 202, 90, 360);
            formGraphics.DrawEllipse(drawwhtPen, 63, 23, 196, 196);

            formGraphics.FillEllipse(WhiteBrush, 63, 23, 196, 196);

            formGraphics.DrawString("P", drawlargeFont, darkGreenBrush, 63, 57);
            formGraphics.DrawString("izza", drawsmallFont, LightGreenBrush, 120, 100);

            //Rotating Graphics
            formGraphics.TranslateTransform(280, 98);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("No Refunds", drawtinyFont, WhiteBrush,new Rectangle());
            formGraphics.ResetTransform();
        }
    }
}
