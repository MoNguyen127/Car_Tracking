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

          private void side_Cam_Click(object sender, EventArgs e)
          {

          }

          private void txt_Name_Enter(object sender, EventArgs e)
          {
               if(txt_Name.Text == "Tên Camera")
               {
                    txt_Name.Text = "";
               }
          }

          private void txt_Name_Leave(object sender, EventArgs e)
          {
               if (txt_Name.Text == "")
               {
                    txt_Name.Text = "Tên Camera";
               }
          }

          private void txt_IPAdress_Leave(object sender, EventArgs e)
          {
               if (txt_IPAdress.Text == "")
               {
                    txt_IPAdress.Text = "Địa Chỉ IP";
               }
          }

          private void txt_IPAdress_Enter(object sender, EventArgs e)
          {
               if (txt_IPAdress.Text == "Địa Chỉ IP")
               {
                    txt_IPAdress.Text = "";
               }
          }

          private void txt_HTTPPort_Enter(object sender, EventArgs e)
          {
               if (txt_HTTPPort.Text == "Cổng HTTP")
               {
                    txt_HTTPPort.Text = "";
               }
          }

          private void txt_RTSPPort_Leave(object sender, EventArgs e)
          {
               
          }

          private void txt_Username_Enter(object sender, EventArgs e)
          {
               if (txt_Username.Text == "Tên Đăng Nhập")
               {
                    txt_Username.Text = "";
               }
          }

          private void txt_Username_Leave(object sender, EventArgs e)
          {
               if (txt_Username.Text == "")
               {
                    txt_Username.Text = "Tên Đăng Nhập";
               }
          }

          private void txt_Password_Enter(object sender, EventArgs e)
          {
               if (txt_Password.Text == "Mật Khẩu")
               {
                    txt_Password.Text = "";
               }
          }

          private void txt_Password_Leave(object sender, EventArgs e)
          {
               if (txt_Password.Text == "")
               {
                    txt_Password.Text = "Mật Khẩu";
               }
          }

          private void txtLoaiCamera_Enter(object sender, EventArgs e)
          {
               if (txt_CamType.Text == "Hãng Camera")
               {
                    txt_CamType.Text = "";
               }
          }

          private void txtLoaiCamera_Leave(object sender, EventArgs e)
          {
               if (txt_CamType.Text == "")
               {
                    txt_CamType.Text = "Hãng Camera";
               }
          }

          private void txtUrlRTSP_Enter(object sender, EventArgs e)
          {
               if (txt_RTSPUrl.Text == "Luồng RTSP")
               {
                    txt_RTSPUrl.Text = "";
               }
          }

          private void txtUrlRTSP_Leave(object sender, EventArgs e)
          {
               if (txt_RTSPUrl.Text == "")
               {
                    txt_RTSPUrl.Text = "Luồng RTSP";
               }
          }

          private void txt_HTTPPort_Leave(object sender, EventArgs e)
          {
               if (txt_HTTPPort.Text == "")
               {
                    txt_HTTPPort.Text = "Cổng HTTP";
               }
          }

          private void txt_Address_Leave(object sender, EventArgs e)
          {
               if (txt_Address.Text == "")
               {
                    txt_Address.Text = "Vị Trí";
               }
          }

          private void txt_Address_Enter(object sender, EventArgs e)
          {
               if (txt_Address.Text == "Vị Trí")
               {
                    txt_Address.Text = "";
               }
          }

          private void txt_RTSPPort_Enter(object sender, EventArgs e)
          {
               if (txt_RTSPPort.Text == "Cổng RTSP")
               {
                    txt_RTSPPort.Text = "";
               }
          }

          private void side_ListCam_Click(object sender, EventArgs e)
          {

          }
     }
}
