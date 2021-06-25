using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using CameraTracker_Database.EF;

using System.IO;

namespace WindowsFormsApp1
{
     public partial class usr_SingleCamGrid : UserControl
     {
          public delegate void SINGLE_CAM_GRID_CLICK(object sender, EventArgs e, CAMERA cam);
          public static event SINGLE_CAM_GRID_CLICK SINGLE_CAM_GRID_CLICKED;
          public delegate void SINGLE_CAM_GRID_DOUBLE_CLICK(object sender, EventArgs e, CAMERA cam);
          public static event SINGLE_CAM_GRID_DOUBLE_CLICK SINGLE_CAM_GRID_DOUBLE_CLICKED;

          ////IpCameraHandler model_Save = new IpCameraHandler();


          private string CAM_URL;
          private CAMERA cam;
          private static int cAMERA_ID;

          VideoCapture _capture;

          Image<Bgr, Byte> frame;
          double FrameRate = 0;
          int FrameRate_Interger = 0;
          double TotalFrames = 0;
          double Framesno = 0;
          double codec_double = 0;
          bool IsPlaying = false;
          int CurrentFrameNo;
          Mat CurrentFrame;

          public usr_SingleCamGrid()
          {
               InitializeComponent();
          }
     }
}
