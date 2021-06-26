namespace CameraTracker.GUI
{
    partial class frmLicensePlate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicensePlate));
            this.expandableSplitter3 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.tbPanelNguyenLieu = new DevComponents.DotNetBar.TabControlPanel();
            this.expandableSplitter4 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.grpGiaoDich = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pic_plate = new System.Windows.Forms.PictureBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lb_Time = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lb_Location = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lb_CamName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpChiTietGiaoDich = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grv_List = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSoTietKiem = new DevComponents.DotNetBar.RibbonBar();
            this.chb_TimeFilter = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dt_Start = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dt_End = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txt_License_Plate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btn_Filter = new DevComponents.DotNetBar.ButtonItem();
            this.tbGiaoDich = new DevComponents.DotNetBar.TabItem(this.components);
            this.cbItemTatCa = new DevComponents.Editors.ComboItem();
            this.cbItemKiemTraDoiTuong = new DevComponents.Editors.ComboItem();
            this.cbItemXacMinhDoiTuong = new DevComponents.Editors.ComboItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.btnNhapSoLieuTieuHao = new DevComponents.DotNetBar.ButtonItem();
            this.btnTheoDoiSoLieuNhapKho = new DevComponents.DotNetBar.ButtonItem();
            this.tbChiTietGiaoDich = new DevComponents.DotNetBar.TabItem(this.components);
            this.comboBoxItem4 = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboBoxItem3 = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboBoxItem2 = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboBoxItem1 = new DevComponents.DotNetBar.ComboBoxItem();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnNhapKho = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.tbSoLuongGiaoDich = new DevComponents.DotNetBar.TabItem(this.components);
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_ViewFull = new DevComponents.DotNetBar.ButtonX();
            this.tbPanelNguyenLieu.SuspendLayout();
            this.grpGiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plate)).BeginInit();
            this.grpChiTietGiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_List)).BeginInit();
            this.MenuSoTietKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandableSplitter3
            // 
            this.expandableSplitter3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter3.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandableSplitter3.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter3.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter3.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter3.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter3.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter3.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter3.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter3.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter3.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter3.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter3.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter3.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter3.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter3.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter3.Location = new System.Drawing.Point(0, 564);
            this.expandableSplitter3.Name = "expandableSplitter3";
            this.expandableSplitter3.Size = new System.Drawing.Size(828, 6);
            this.expandableSplitter3.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter3.TabIndex = 69;
            this.expandableSplitter3.TabStop = false;
            // 
            // tbPanelNguyenLieu
            // 
            this.tbPanelNguyenLieu.Controls.Add(this.expandableSplitter4);
            this.tbPanelNguyenLieu.Controls.Add(this.grpGiaoDich);
            this.tbPanelNguyenLieu.Controls.Add(this.grpChiTietGiaoDich);
            this.tbPanelNguyenLieu.Controls.Add(this.MenuSoTietKiem);
            this.tbPanelNguyenLieu.DisabledBackColor = System.Drawing.Color.Empty;
            this.tbPanelNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanelNguyenLieu.Location = new System.Drawing.Point(0, 29);
            this.tbPanelNguyenLieu.Name = "tbPanelNguyenLieu";
            this.tbPanelNguyenLieu.Padding = new System.Windows.Forms.Padding(1);
            this.tbPanelNguyenLieu.Size = new System.Drawing.Size(1209, 661);
            this.tbPanelNguyenLieu.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tbPanelNguyenLieu.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tbPanelNguyenLieu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tbPanelNguyenLieu.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tbPanelNguyenLieu.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tbPanelNguyenLieu.Style.GradientAngle = 90;
            this.tbPanelNguyenLieu.TabIndex = 1;
            this.tbPanelNguyenLieu.TabItem = this.tbGiaoDich;
            // 
            // expandableSplitter4
            // 
            this.expandableSplitter4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter4.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter4.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter4.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter4.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter4.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter4.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter4.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter4.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter4.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter4.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter4.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter4.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter4.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter4.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter4.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter4.Location = new System.Drawing.Point(372, 63);
            this.expandableSplitter4.Name = "expandableSplitter4";
            this.expandableSplitter4.Size = new System.Drawing.Size(2, 597);
            this.expandableSplitter4.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter4.TabIndex = 67;
            this.expandableSplitter4.TabStop = false;
            // 
            // grpGiaoDich
            // 
            this.grpGiaoDich.CanvasColor = System.Drawing.Color.Empty;
            this.grpGiaoDich.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpGiaoDich.Controls.Add(this.btn_ViewFull);
            this.grpGiaoDich.Controls.Add(this.pic_plate);
            this.grpGiaoDich.Controls.Add(this.labelX7);
            this.grpGiaoDich.Controls.Add(this.labelX4);
            this.grpGiaoDich.Controls.Add(this.lb_Time);
            this.grpGiaoDich.Controls.Add(this.labelX3);
            this.grpGiaoDich.Controls.Add(this.lb_Location);
            this.grpGiaoDich.Controls.Add(this.labelX2);
            this.grpGiaoDich.Controls.Add(this.lb_CamName);
            this.grpGiaoDich.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpGiaoDich.Location = new System.Drawing.Point(1, 63);
            this.grpGiaoDich.Name = "grpGiaoDich";
            this.grpGiaoDich.Size = new System.Drawing.Size(367, 597);
            // 
            // 
            // 
            this.grpGiaoDich.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpGiaoDich.Style.BackColorGradientAngle = 90;
            this.grpGiaoDich.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpGiaoDich.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpGiaoDich.Style.BorderBottomWidth = 1;
            this.grpGiaoDich.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpGiaoDich.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpGiaoDich.Style.BorderLeftWidth = 1;
            this.grpGiaoDich.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpGiaoDich.Style.BorderRightWidth = 1;
            this.grpGiaoDich.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpGiaoDich.Style.BorderTopWidth = 1;
            this.grpGiaoDich.Style.CornerDiameter = 4;
            this.grpGiaoDich.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpGiaoDich.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpGiaoDich.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpGiaoDich.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpGiaoDich.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpGiaoDich.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpGiaoDich.TabIndex = 66;
            this.grpGiaoDich.Text = "Chi tiết";
            // 
            // pic_plate
            // 
            this.pic_plate.Location = new System.Drawing.Point(106, 169);
            this.pic_plate.Margin = new System.Windows.Forms.Padding(4);
            this.pic_plate.Name = "pic_plate";
            this.pic_plate.Size = new System.Drawing.Size(217, 120);
            this.pic_plate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_plate.TabIndex = 109;
            this.pic_plate.TabStop = false;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(9, 169);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(36, 21);
            this.labelX7.TabIndex = 108;
            this.labelX7.Text = "Ảnh:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 123);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(74, 21);
            this.labelX4.TabIndex = 107;
            this.labelX4.Text = "Thời gian:";
            // 
            // lb_Time
            // 
            this.lb_Time.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_Time.Border.Class = "TextBoxBorder";
            this.lb_Time.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Time.Location = new System.Drawing.Point(106, 124);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.PreventEnterBeep = true;
            this.lb_Time.ReadOnly = true;
            this.lb_Time.Size = new System.Drawing.Size(178, 26);
            this.lb_Time.TabIndex = 106;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 77);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 21);
            this.labelX3.TabIndex = 105;
            this.labelX3.Text = "Vị trí:";
            // 
            // lb_Location
            // 
            this.lb_Location.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_Location.Border.Class = "TextBoxBorder";
            this.lb_Location.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Location.Location = new System.Drawing.Point(106, 77);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.PreventEnterBeep = true;
            this.lb_Location.ReadOnly = true;
            this.lb_Location.Size = new System.Drawing.Size(178, 26);
            this.lb_Location.TabIndex = 104;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 31);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 21);
            this.labelX2.TabIndex = 103;
            this.labelX2.Text = "Camera:";
            // 
            // lb_CamName
            // 
            this.lb_CamName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_CamName.Border.Class = "TextBoxBorder";
            this.lb_CamName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_CamName.Location = new System.Drawing.Point(106, 30);
            this.lb_CamName.Name = "lb_CamName";
            this.lb_CamName.PreventEnterBeep = true;
            this.lb_CamName.ReadOnly = true;
            this.lb_CamName.Size = new System.Drawing.Size(178, 26);
            this.lb_CamName.TabIndex = 102;
            // 
            // grpChiTietGiaoDich
            // 
            this.grpChiTietGiaoDich.CanvasColor = System.Drawing.Color.Empty;
            this.grpChiTietGiaoDich.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpChiTietGiaoDich.Controls.Add(this.grv_List);
            this.grpChiTietGiaoDich.Controls.Add(this.expandableSplitter3);
            this.grpChiTietGiaoDich.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpChiTietGiaoDich.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpChiTietGiaoDich.Location = new System.Drawing.Point(374, 63);
            this.grpChiTietGiaoDich.Name = "grpChiTietGiaoDich";
            this.grpChiTietGiaoDich.Size = new System.Drawing.Size(834, 597);
            // 
            // 
            // 
            this.grpChiTietGiaoDich.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpChiTietGiaoDich.Style.BackColorGradientAngle = 90;
            this.grpChiTietGiaoDich.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpChiTietGiaoDich.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChiTietGiaoDich.Style.BorderBottomWidth = 1;
            this.grpChiTietGiaoDich.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpChiTietGiaoDich.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChiTietGiaoDich.Style.BorderLeftWidth = 1;
            this.grpChiTietGiaoDich.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChiTietGiaoDich.Style.BorderRightWidth = 1;
            this.grpChiTietGiaoDich.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChiTietGiaoDich.Style.BorderTopWidth = 1;
            this.grpChiTietGiaoDich.Style.CornerDiameter = 4;
            this.grpChiTietGiaoDich.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpChiTietGiaoDich.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpChiTietGiaoDich.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpChiTietGiaoDich.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpChiTietGiaoDich.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpChiTietGiaoDich.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpChiTietGiaoDich.TabIndex = 67;
            this.grpChiTietGiaoDich.Text = "Danh sách";
            // 
            // grv_List
            // 
            this.grv_List.AllowUserToAddRows = false;
            this.grv_List.AllowUserToDeleteRows = false;
            this.grv_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.col_Seq,
            this.col_Camera,
            this.col_Location,
            this.col_Time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_List.DefaultCellStyle = dataGridViewCellStyle5;
            this.grv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grv_List.HighlightSelectedColumnHeaders = false;
            this.grv_List.Location = new System.Drawing.Point(0, 0);
            this.grv_List.Margin = new System.Windows.Forms.Padding(4);
            this.grv_List.MultiSelect = false;
            this.grv_List.Name = "grv_List";
            this.grv_List.ReadOnly = true;
            this.grv_List.RowHeadersWidth = 40;
            this.grv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_List.Size = new System.Drawing.Size(828, 564);
            this.grv_List.TabIndex = 70;
            this.grv_List.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grv_List_CellMouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "license_camera_id";
            this.ID.HeaderText = "Mã";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // col_Seq
            // 
            this.col_Seq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Seq.DataPropertyName = "seq";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.col_Seq.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Seq.HeaderText = "STT";
            this.col_Seq.MinimumWidth = 6;
            this.col_Seq.Name = "col_Seq";
            this.col_Seq.ReadOnly = true;
            // 
            // col_Camera
            // 
            this.col_Camera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Camera.DataPropertyName = "camera_name";
            this.col_Camera.HeaderText = "Camera";
            this.col_Camera.MinimumWidth = 6;
            this.col_Camera.Name = "col_Camera";
            this.col_Camera.ReadOnly = true;
            // 
            // col_Location
            // 
            this.col_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Location.DataPropertyName = "location";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.col_Location.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Location.FillWeight = 43.85965F;
            this.col_Location.HeaderText = "Vị trí";
            this.col_Location.MinimumWidth = 6;
            this.col_Location.Name = "col_Location";
            this.col_Location.ReadOnly = true;
            // 
            // col_Time
            // 
            this.col_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Time.DataPropertyName = "time";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Time.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_Time.FillWeight = 43.85965F;
            this.col_Time.HeaderText = "Thời gian";
            this.col_Time.MinimumWidth = 6;
            this.col_Time.Name = "col_Time";
            this.col_Time.ReadOnly = true;
            // 
            // MenuSoTietKiem
            // 
            this.MenuSoTietKiem.AutoOverflowEnabled = true;
            this.MenuSoTietKiem.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.MenuSoTietKiem.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.MenuSoTietKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MenuSoTietKiem.ContainerControlProcessDialogKey = true;
            this.MenuSoTietKiem.Controls.Add(this.chb_TimeFilter);
            this.MenuSoTietKiem.Controls.Add(this.labelX1);
            this.MenuSoTietKiem.Controls.Add(this.dt_Start);
            this.MenuSoTietKiem.Controls.Add(this.labelX5);
            this.MenuSoTietKiem.Controls.Add(this.labelX6);
            this.MenuSoTietKiem.Controls.Add(this.dt_End);
            this.MenuSoTietKiem.Controls.Add(this.txt_License_Plate);
            this.MenuSoTietKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSoTietKiem.DragDropSupport = true;
            this.MenuSoTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MenuSoTietKiem.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.labelItem1,
            this.btn_Filter});
            this.MenuSoTietKiem.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.MenuSoTietKiem.Location = new System.Drawing.Point(1, 1);
            this.MenuSoTietKiem.Margin = new System.Windows.Forms.Padding(5);
            this.MenuSoTietKiem.Name = "MenuSoTietKiem";
            this.MenuSoTietKiem.ShowShortcutKeysInToolTips = true;
            this.MenuSoTietKiem.Size = new System.Drawing.Size(1207, 62);
            this.MenuSoTietKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.MenuSoTietKiem.TabIndex = 6;
            // 
            // 
            // 
            this.MenuSoTietKiem.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.MenuSoTietKiem.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // chb_TimeFilter
            // 
            // 
            // 
            // 
            this.chb_TimeFilter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chb_TimeFilter.Location = new System.Drawing.Point(287, 19);
            this.chb_TimeFilter.Name = "chb_TimeFilter";
            this.chb_TimeFilter.Size = new System.Drawing.Size(146, 23);
            this.chb_TimeFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chb_TimeFilter.TabIndex = 101;
            this.chb_TimeFilter.Text = "Lọc theo thời gian";
            this.chb_TimeFilter.CheckedChanged += new System.EventHandler(this.chb_TimeFilter_CheckedChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 20);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 21);
            this.labelX1.TabIndex = 100;
            this.labelX1.Text = "Biển số:";
            // 
            // dt_Start
            // 
            // 
            // 
            // 
            this.dt_Start.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_Start.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_Start.ButtonDropDown.Visible = true;
            this.dt_Start.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dt_Start.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dt_Start.IsPopupCalendarOpen = false;
            this.dt_Start.Location = new System.Drawing.Point(461, 11);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_Start.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_Start.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_Start.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_Start.MonthCalendar.DisplayMonth = new System.DateTime(2010, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dt_Start.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_Start.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_Start.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_Start.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_Start.MonthCalendar.TodayButtonVisible = true;
            this.dt_Start.Name = "dt_Start";
            this.dt_Start.Size = new System.Drawing.Size(98, 26);
            this.dt_Start.TabIndex = 96;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(479, 39);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 21);
            this.labelX5.TabIndex = 99;
            this.labelX5.Text = "Từ ngày:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(591, 40);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(76, 21);
            this.labelX6.TabIndex = 98;
            this.labelX6.Text = "Đến ngày:";
            // 
            // dt_End
            // 
            // 
            // 
            // 
            this.dt_End.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_End.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_End.ButtonDropDown.Visible = true;
            this.dt_End.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dt_End.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dt_End.IsPopupCalendarOpen = false;
            this.dt_End.Location = new System.Drawing.Point(574, 10);
            this.dt_End.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_End.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_End.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_End.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_End.MonthCalendar.DisplayMonth = new System.DateTime(2010, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dt_End.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_End.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_End.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_End.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_End.MonthCalendar.TodayButtonVisible = true;
            this.dt_End.Name = "dt_End";
            this.dt_End.Size = new System.Drawing.Size(98, 26);
            this.dt_End.TabIndex = 97;
            // 
            // txt_License_Plate
            // 
            this.txt_License_Plate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_License_Plate.Border.Class = "TextBoxBorder";
            this.txt_License_Plate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_License_Plate.Location = new System.Drawing.Point(81, 17);
            this.txt_License_Plate.Name = "txt_License_Plate";
            this.txt_License_Plate.PreventEnterBeep = true;
            this.txt_License_Plate.ReadOnly = true;
            this.txt_License_Plate.Size = new System.Drawing.Size(178, 26);
            this.txt_License_Plate.TabIndex = 48;
            this.txt_License_Plate.TextChanged += new System.EventHandler(this.txt_License_Plate_TextChanged);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "                                                            ";
            this.labelItem2.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "                                                                                 " +
    "             ";
            // 
            // btn_Filter
            // 
            this.btn_Filter.BeginGroup = true;
            this.btn_Filter.Image = global::CameraTracker.Properties.Resources.search;
            this.btn_Filter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.RibbonWordWrap = false;
            this.btn_Filter.SubItemsExpandWidth = 14;
            this.btn_Filter.Text = "Tìm kiếm";
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // tbGiaoDich
            // 
            this.tbGiaoDich.AttachedControl = this.tbPanelNguyenLieu;
            this.tbGiaoDich.Name = "tbGiaoDich";
            this.tbGiaoDich.Text = "Tra cứu theo biển số";
            // 
            // cbItemTatCa
            // 
            this.cbItemTatCa.Text = "Tất cả";
            // 
            // cbItemKiemTraDoiTuong
            // 
            this.cbItemKiemTraDoiTuong.Text = "Kiểm tra đối tượng";
            // 
            // cbItemXacMinhDoiTuong
            // 
            this.cbItemXacMinhDoiTuong.Text = "Xác minh đối tượng";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "  ";
            // 
            // btnNhapSoLieuTieuHao
            // 
            this.btnNhapSoLieuTieuHao.Name = "btnNhapSoLieuTieuHao";
            this.btnNhapSoLieuTieuHao.Text = "Chi tiết";
            this.btnNhapSoLieuTieuHao.Visible = false;
            // 
            // btnTheoDoiSoLieuNhapKho
            // 
            this.btnTheoDoiSoLieuNhapKho.Name = "btnTheoDoiSoLieuNhapKho";
            this.btnTheoDoiSoLieuNhapKho.Text = "Tổng hợp";
            // 
            // tbChiTietGiaoDich
            // 
            this.tbChiTietGiaoDich.Name = "tbChiTietGiaoDich";
            this.tbChiTietGiaoDich.Text = "Chi tiết giao dịch";
            this.tbChiTietGiaoDich.Visible = false;
            // 
            // comboBoxItem4
            // 
            this.comboBoxItem4.Caption = "Chọn bầu cử con";
            this.comboBoxItem4.ComboWidth = 150;
            this.comboBoxItem4.DropDownHeight = 106;
            this.comboBoxItem4.ItemHeight = 17;
            this.comboBoxItem4.Name = "comboBoxItem4";
            // 
            // comboBoxItem3
            // 
            this.comboBoxItem3.Caption = "Chọn bầu cử con";
            this.comboBoxItem3.ComboWidth = 150;
            this.comboBoxItem3.DropDownHeight = 106;
            this.comboBoxItem3.ItemHeight = 17;
            this.comboBoxItem3.Name = "comboBoxItem3";
            // 
            // comboBoxItem2
            // 
            this.comboBoxItem2.Caption = "Chọn bầu cử con";
            this.comboBoxItem2.ComboWidth = 150;
            this.comboBoxItem2.DropDownHeight = 106;
            this.comboBoxItem2.ItemHeight = 17;
            this.comboBoxItem2.Name = "comboBoxItem2";
            // 
            // comboBoxItem1
            // 
            this.comboBoxItem1.Caption = "Chọn bầu cử con";
            this.comboBoxItem1.ComboWidth = 150;
            this.comboBoxItem1.DropDownHeight = 106;
            this.comboBoxItem1.ItemHeight = 17;
            this.comboBoxItem1.Name = "comboBoxItem1";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tbPanelNguyenLieu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 690);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tbGiaoDich);
            this.tabControl1.Text = "tabControlGiaoDich";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tbPanelNguyenLieu;
            this.tabItem1.Image = ((System.Drawing.Image)(resources.GetObject("tabItem1.Image")));
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Tra cứu giao dịch";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BeginGroup = true;
            this.btnNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.Image")));
            this.btnNhapKho.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.RibbonWordWrap = false;
            this.btnNhapKho.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.Tooltip = "Theo dõi số liệu nhập kho";
            // 
            // buttonItem8
            // 
            this.buttonItem8.BeginGroup = true;
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.RibbonWordWrap = false;
            this.buttonItem8.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonItem8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNhapKho});
            this.buttonItem8.Text = "Tồn kho";
            this.buttonItem8.Tooltip = "Theo dõi số liệu tồn kho";
            // 
            // tbSoLuongGiaoDich
            // 
            this.tbSoLuongGiaoDich.Image = ((System.Drawing.Image)(resources.GetObject("tbSoLuongGiaoDich.Image")));
            this.tbSoLuongGiaoDich.Name = "tbSoLuongGiaoDich";
            this.tbSoLuongGiaoDich.Text = "Chi tiết giao dịch";
            // 
            // buttonItem2
            // 
            this.buttonItem2.BeginGroup = true;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Thoát";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BeginGroup = true;
            this.btnLamMoi.Image = global::CameraTracker.Properties.Resources.search;
            this.btnLamMoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.RibbonWordWrap = false;
            this.btnLamMoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnLamMoi.Text = "Tìm kiếm";
            this.btnLamMoi.Tooltip = "Tìm kiếm";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // btn_ViewFull
            // 
            this.btn_ViewFull.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ViewFull.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ViewFull.Location = new System.Drawing.Point(106, 315);
            this.btn_ViewFull.Name = "btn_ViewFull";
            this.btn_ViewFull.Size = new System.Drawing.Size(208, 30);
            this.btn_ViewFull.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ViewFull.TabIndex = 71;
            this.btn_ViewFull.Text = "Xem ảnh kích thước đầy đủ";
            this.btn_ViewFull.Click += new System.EventHandler(this.btn_ViewFull_Click);
            // 
            // frmLicensePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 690);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLicensePlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu theo biển số";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbPanelNguyenLieu.ResumeLayout(false);
            this.grpGiaoDich.ResumeLayout(false);
            this.grpGiaoDich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plate)).EndInit();
            this.grpChiTietGiaoDich.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_List)).EndInit();
            this.MenuSoTietKiem.ResumeLayout(false);
            this.MenuSoTietKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.ExpandableSplitter expandableSplitter3;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tbPanelNguyenLieu;
        public DevComponents.DotNetBar.ExpandableSplitter expandableSplitter4;
        private DevComponents.DotNetBar.Controls.GroupPanel grpGiaoDich;
        private DevComponents.DotNetBar.Controls.GroupPanel grpChiTietGiaoDich;
        private DevComponents.Editors.ComboItem cbItemTatCa;
        private DevComponents.Editors.ComboItem cbItemKiemTraDoiTuong;
        private DevComponents.Editors.ComboItem cbItemXacMinhDoiTuong;
        private DevComponents.DotNetBar.TabItem tbGiaoDich;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.ButtonItem btnNhapKho;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.TabItem tbSoLuongGiaoDich;
        private DevComponents.DotNetBar.ButtonItem btnNhapSoLieuTieuHao;
        private DevComponents.DotNetBar.ButtonItem btnTheoDoiSoLieuNhapKho;
        private DevComponents.DotNetBar.TabItem tbChiTietGiaoDich;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem4;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem3;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem2;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.RibbonBar MenuSoTietKiem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_Start;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_End;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_License_Plate;
        private DevComponents.DotNetBar.ButtonItem btn_Filter;
        private DevComponents.DotNetBar.ButtonItem btnLamMoi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chb_TimeFilter;
        private DevComponents.DotNetBar.Controls.DataGridViewX grv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Camera;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX lb_Time;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX lb_Location;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX lb_CamName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.PictureBox pic_plate;
        private DevComponents.DotNetBar.ButtonX btn_ViewFull;
    }
}