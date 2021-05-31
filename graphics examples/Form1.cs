using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Graphics examples";

            Graphics g = this.CreateGraphics();
            //Pen redPen = new Pen(Color.Red, 10);
            //SolidBrush whiteBrush = new SolidBrush(Color.White);

            Font drawFont = new Font("Symbol", 40, FontStyle.Bold);

            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            g.Clear(Color.White);

            //g.DrawLine(redPen, 50, 10, 100, 200);

            //g.DrawRectangle(redPen, 30, 30, 100, 200);

            //g.FillRectangle(blueBrush, 30, 30, 100, 200);

            //g.DrawEllipse(redPen, 25, 25, 200, 200);

            //g.FillEllipse(blueBrush, 25, 25, 200, 200);

            ////g.DrawArc(redPen, 250, 20, 50, 50, 120, 300);

            ////g.DrawPie(redPen, 250, 20, 50, 50, 0, 70);

            //g.FillPie(blueBrush, 250, 20, 50, 50, 120, 300);

            //g.DrawString("Hello", drawFont, blueBrush, 400, 40);



            //logo code
            g.FillRectangle(blueBrush, 30, 30, 200, 100);
            g.FillEllipse(yellowBrush, 30, 30, 200, 100);
            g.DrawString("I K E A", drawFont, blueBrush, 40, 45);






        }
    }
}
