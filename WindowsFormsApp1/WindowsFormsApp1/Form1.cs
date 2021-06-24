using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }


          private void DrawBorder(object sender, PaintEventArgs e)
          {
               Rectangle rect = new Rectangle(this.cb_CamType.Location.X - 1, this.cb_CamType.Location.Y - 1, this.cb_CamType.Width + 1, this.cb_CamType.Height + 1);

               Pen pen = new Pen(Color.LightSteelBlue, 2);
               Graphics g = e.Graphics;

               g.DrawRectangle(pen, rect);
               this.cb_CamType.Refresh();
          }

          private void side_AddCam_Click(object sender, EventArgs e)
          {
               this.Paint += DrawBorder;
          }
     }
}
