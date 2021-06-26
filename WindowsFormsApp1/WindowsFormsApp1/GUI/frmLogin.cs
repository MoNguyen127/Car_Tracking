using CameraTracker.Common;
using CameraTracker_Database.EF;
using CameraTracker_Database.Services.Services;
using System;
using System.IO;
using System.Windows.Forms;


namespace CameraTracker.GUI
{
    public partial class frmLogin: DevComponents.DotNetBar.Office2007Form
    {
        F_USER f_user = new F_USER();
        public frmLogin()
        {
            InitializeComponent();            
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Helper.IsLogin = false;
            this.Close();
        }       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Enter username and password !",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    USER user = f_user.Login(txtUsername.Text, txtPassword.Text);
                    if (user != null)
                    {
                        Helper.IsLogin = true;
                        Helper.userLogin = user;
                        //Helper.listMonitor = new F_USER_MONITORING_PLATE().GetMany(x => x.User_ID == user.User_ID && x.IsStop == false)
                            //.Select(x => x.License_Plate_ID).ToList();
                        Helper.timeLogin = DateTime.Now;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or Password", "Information");
                        txtPassword.Text = string.Empty;
                    }
                }
            }
            catch
            {
            }
        }

        

        private void ceHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
