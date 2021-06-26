using System;
using System.Data;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using CameraTracker.Model;
using CameraTracker_Database.Services.Services;
using CameraTracker_Database.EF;
using System.Linq;
using CameraTracker.Common;
using CameraTracker.UserControl.Vehicle;

namespace CameraTracker.GUI
{
    public partial class frmLicensePlate : DevComponents.DotNetBar.Office2007Form
    {
        private List<LicensePlateRouteView> routes;
        private F_LICENSE_PLATE_CAMERA f_license_cam;
        private F_LICENSE_PLATE f_license;
        private bool IsTimeFilter = false;
        private long CURRENT_SELECTED_LICENSE_PLATE_CAMERA_ID = 0;
        public frmLicensePlate()
        {           
            //_activeTabNumber = ActiveTabNumber;
            InitializeComponent();
            grv_List.AutoGenerateColumns = false;
        }

        private void chb_TimeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (IsTimeFilter)
            {
                IsTimeFilter = false;
                dt_Start.Enabled = false;
                dt_End.Enabled = false;
            }
            else
            {
                IsTimeFilter = true;
                dt_Start.Enabled = true;
                dt_End.Enabled = true;
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            routes = new List<LicensePlateRouteView>();
            f_license_cam = new F_LICENSE_PLATE_CAMERA();
            f_license = new F_LICENSE_PLATE();
            LICENSE_PLATE license_plate = f_license.GetSingleByCondition(x => x.Series == txt_License_Plate.Text);
            if (license_plate == null)
            {
                MessageBox.Show("No data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<LICENSE_PLATE_CAMERA> list_license_cam;
            int seq = 0;
            if (IsTimeFilter)
            {
                list_license_cam = f_license_cam.GetMany(x => x.License_Plate_ID == license_plate.License_Plate_ID && x.Time > dt_Start.Value && x.Time < dt_End.Value).OrderBy(x => x.Time).ToList();
            }
            else
            {
                list_license_cam = f_license_cam.GetMany(x => x.License_Plate_ID == license_plate.License_Plate_ID).OrderBy(x => x.Time).ToList();

            }
            foreach (var item in list_license_cam)
            {
                seq++;
                LicensePlateRouteView temp = new LicensePlateRouteView();
                temp.seq = seq;
                temp.license_camera_id = item.License_Plate_Camera_ID;
                temp.cam_name = item.CAMERA.Name;
                temp.location = item.CAMERA.Location;
                temp.time = item.Time.Value.ToString("HH:mm:ss dd/MM/yyyy");
                routes.Add(temp);
            }
            grv_List.DataSource = routes;
        }

        private void txt_License_Plate_TextChanged(object sender, EventArgs e)
        {
            if (txt_License_Plate.Text == string.Empty || txt_License_Plate.Text == "")
            {
                btn_Filter.Enabled = false;
            }
            else btn_Filter.Enabled = true;
        }

        private void grv_List_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CURRENT_SELECTED_LICENSE_PLATE_CAMERA_ID = Convert.ToInt32(grv_List.Rows[e.RowIndex].Cells[0].Value.ToString());
            LicensePlateRouteView temp = routes.SingleOrDefault(x => x.license_camera_id == CURRENT_SELECTED_LICENSE_PLATE_CAMERA_ID);
            lb_CamName.Text = temp.cam_name;
            lb_Location.Text = temp.location;
            lb_Time.Text = temp.time;
            try
            {
                pic_plate.Image = Image.FromStream(Helper.GetImageUrl(f_license_cam.GetSingleById(CURRENT_SELECTED_LICENSE_PLATE_CAMERA_ID)));
            }
            catch
            {
                pic_plate.Image = null;
            }
            btn_ViewFull.Enabled = true;
        }

        private void btn_ViewFull_Click(object sender, EventArgs e)
        {
            try
            {
                //nhớ
                frm_ViewFullImage frm = new frm_ViewFullImage(Image.FromStream(Helper.GetFullImageUrl(f_license_cam.GetSingleById(CURRENT_SELECTED_LICENSE_PLATE_CAMERA_ID))));
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Cannot load image !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
