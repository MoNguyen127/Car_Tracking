///* 
// * 02_PTZ_Camera_Motion_Control
// * You can set an IP camera and change the camera properties with this application 
// * 
// * IPCameraHandler class controlling the IPCamera object
// * 
// * If you want more information http://www.camera-sdk.com/ check our link. 
// */
//using System;
//using System.Text;
//using Ozeki.Camera;
//using Ozeki.Media;
//using _03_Onvif_Network_Video_Recorder.LOG;

//namespace WindowsFormsApp1
//{
//     class IpCameraHandler
//     {
//          private MediaConnector Connector;

//          private MPEG4Recorder _mpeg4Recorder;

//          public OzekiCamera Camera { get; private set; }
//          public DrawingImageProvider ImageProvider { get; private set; }

//          public event EventHandler<CameraStateEventArgs> CameraStateChanged;
//          public event EventHandler<CameraErrorEventArgs> CameraErrorOccured;



//          public IpCameraHandler()
//          {
//               ImageProvider = new DrawingImageProvider();
//               Connector = new MediaConnector();
//          }

//          public void ConnectOnvifCamera(string cameraUrl)
//          {
//               if (Camera != null)
//                    CloseCamera();

//               // Gets the camera, which can be reached by the address, and requires authentication.
//               Camera = new OzekiCamera(cameraUrl);



//               if (Camera == null) return;
//               Connector.Connect(Camera.VideoChannel, ImageProvider);

//               Camera.CameraStateChanged += Camera_CameraStateChanged;
//               Camera.CameraErrorOccurred += Camera_CameraErrorOccurred;

//               Camera.Start();
//          }

//          private void Camera_CameraErrorOccurred(object sender, CameraErrorEventArgs e)
//          {
//               // signal to GUI
//               var handler = CameraErrorOccured;
//               if (handler != null)
//                    handler(this, e);
//          }

//          private void Camera_CameraStateChanged(object sender, CameraStateEventArgs e)
//          {
//               // signal to GUI
//               var handler = CameraStateChanged;
//               if (handler != null)
//                    handler(this, e);
//          }

//          public void Disconnect()
//          {
//               CloseCamera();
//          }

//          private void CloseCamera()
//          {
//               if (Camera == null)
//                    return;

//               Connector.Disconnect(Camera.VideoChannel, ImageProvider);
//               Camera.Disconnect();
//               Camera.Dispose();
//          }

//          public void Stop()
//          {
//               if (Camera != null)
//               {
//                    Connector.Dispose();
//                    CloseCamera();
//                    ImageProvider.Dispose();
//               }
//          }

//          public string GetDeviceInfo()
//          {
//               var sb = new StringBuilder();
//               sb.AppendLine(@"Firmware - " + Camera.CameraInfo.DeviceInfo.Firmware + "\n");
//               sb.AppendLine(@"ID phần cứng - " + Camera.CameraInfo.DeviceInfo.HardwareId + "\n");
//               sb.AppendLine(@"Nhà sản xuất - " + Camera.CameraInfo.DeviceInfo.Manufacturer + "\n");
//               sb.AppendLine(@"Mẫu - " + Camera.CameraInfo.DeviceInfo.Model + "\n");
//               sb.AppendLine(@"Số seri - " + Camera.CameraInfo.DeviceInfo.SerialNumber + "\n");
//               sb.AppendLine(@"Chuỗi RTSP - " + Camera.CurrentRtspUri + "\n");



//               return sb.ToString();
//          }

//          public string rtsp_root(string cameraUrl)
//          {
//               string _rtsp_root;
//               Camera = new OzekiCamera(cameraUrl);
//               _rtsp_root = Camera.CurrentRtspUri;
//               return _rtsp_root;
//          }

//          public string StreamInfoAudio()
//          {
//               if (Camera.CurrentStream.AudioEncoding == null) return "";
//               var sb = new StringBuilder();

//               sb.AppendLine(" - Mã hóa âm thanh \n");
//               sb.AppendLine("\t Tốc độ bit - " + Camera.CurrentStream.AudioEncoding.Bitrate + "\n");
//               sb.AppendLine("\t Mã hóa - " + Camera.CurrentStream.AudioEncoding.Encoding + "\n");
//               sb.AppendLine("\t Tỷ lệ mẫu - " + Camera.CurrentStream.AudioEncoding.SampleRate + "\n");
//               sb.AppendLine("\t Phiên thời gian - " + Camera.CurrentStream.AudioEncoding.SessionTimeOut + "\n");
//               sb.AppendLine("\t Use count - " + Camera.CurrentStream.AudioEncoding.UseCount + "\n");

//               sb.AppendLine(" - Nguồn âm thanh \n");
//               sb.AppendLine("\t Kênh - " + Camera.CurrentStream.AudioSource.Channels + "\n");
//               sb.AppendLine("\t Số lượng sử dụng - " + Camera.CurrentStream.AudioSource.UseCount + "\n");

//               return sb.ToString();
//          }

//          public string StreamInfoVideo()
//          {
//               var sb = new StringBuilder();

//               sb.AppendLine(" - Mã hóa video \n");
//               sb.AppendLine("\t Tốc độ bit - " + Camera.CurrentStream.VideoEncoding.BitRate + "\n");
//               sb.AppendLine("\t Mã hóa - " + Camera.CurrentStream.VideoEncoding.Encoding + "\n");
//               sb.AppendLine("\t Thời gian mã hóa - " + Camera.CurrentStream.VideoEncoding.EncodingInterval + "\n");
//               sb.AppendLine("\t Framerate - " + Camera.CurrentStream.VideoEncoding.FrameRate + "\n");
//               sb.AppendLine("\t Chất lượng - " + Camera.CurrentStream.VideoEncoding.Quality + "\n");
//               sb.AppendLine("\t Độ phân giải - " + Camera.CurrentStream.VideoEncoding.Resolution + "\n");
//               sb.AppendLine("\t Phiên thời gian - " + Camera.CurrentStream.VideoEncoding.SessionTimeout + "\n");
//               sb.AppendLine("\t Use count - " + Camera.CurrentStream.VideoEncoding.UseCount + "\n");

//               sb.AppendLine(" - Nguồn video \n");
//               sb.AppendLine("\t Giới hạn - " + Camera.CurrentStream.VideoSource.Bounds + "\n");
//               sb.AppendLine("\t Số lượng sử dụng - " + Camera.CurrentStream.VideoSource.UseCount + "\n");

//               return sb.ToString();
//          }

//          public void Move(string direction)
//          {
//               if (Camera == null) return;
//               switch (direction)
//               {
//                    case "Trên Trái":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.LeftUp);
//                         break;
//                    case "Trên":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.Up);
//                         break;
//                    case "Trên Phải":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.RightUp);
//                         break;
//                    case "Trái":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.Left);
//                         break;
//                    case "Phải":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.Right);
//                         break;
//                    case "Dưới Trái":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.LeftDown);
//                         break;
//                    case "Dưới":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.Down);
//                         break;
//                    case "Dưới Phải":
//                         Camera.CameraMovement.ContinuousMove(MoveDirection.RightDown);
//                         break;
//                    case "Set home":
//                         Camera.CameraMovement.SetHome();
//                         break;
//                    case "In":
//                         Camera.CameraMovement.Zoom(MoveDirection.In);
//                         break;
//                    case "Out":
//                         Camera.CameraMovement.Zoom(MoveDirection.Out);
//                         break;

//               }
//          }

//          public void StartVideoCapture(string path)
//          {
//               if (Camera == null) return;

//               var date = DateTime.Now.Year + "y-" + DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-" +
//                          DateTime.Now.Hour + "h-" + DateTime.Now.Minute + "m-" + DateTime.Now.Second + "s";

//               string currentpath;
//               if (String.IsNullOrEmpty(path))
//                    currentpath = AppDomain.CurrentDomain.BaseDirectory + date + ".mp4";
//               else
//                    currentpath = path + "\\" + date + ".mp4";

//               _mpeg4Recorder = new MPEG4Recorder(currentpath);
//               _mpeg4Recorder.MultiplexFinished += Mpeg4Recorder_MultiplexFinished;

//               //Connector.Connect(Camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
//               Connector.Connect(Camera.VideoChannel, _mpeg4Recorder.VideoRecorder);

//               Log.Write("Video capture has been started");
//               Log.Write("The captured video will be saved: " + currentpath);
//          }

//          private void Mpeg4Recorder_MultiplexFinished(object sender, VoIPEventArgs<bool> e)
//          {

//               if (_mpeg4Recorder == null) return;

//               //Connector.Disconnect(Camera.AudioChannel, recorder.AudioRecorder);
//               Connector.Disconnect(Camera.VideoChannel, _mpeg4Recorder.VideoRecorder);

//               _mpeg4Recorder.Dispose();

//               Log.Write("The captured video has been saved");
//          }

//          public void StopVideoCapture()
//          {
//               if (Camera == null || _mpeg4Recorder == null) return;

//               _mpeg4Recorder.Multiplex();

//               Connector.Disconnect(Camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
//               Connector.Disconnect(Camera.VideoChannel, _mpeg4Recorder.VideoRecorder);

//               Log.Write("Video capture has been stopped");

//          }
//     }
//}
