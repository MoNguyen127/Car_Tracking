
namespace WindowsFormsApp1
{
     partial class usr_CameraView
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usr_CameraView));
               this.pnl_main = new System.Windows.Forms.Panel();
               this.panel4 = new System.Windows.Forms.Panel();
               this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
               this.comboBox1 = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
               this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.panel15 = new System.Windows.Forms.Panel();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label1 = new System.Windows.Forms.Label();
               this.panel4.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // pnl_main
               // 
               this.pnl_main.BackColor = System.Drawing.Color.LightSteelBlue;
               this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pnl_main.Location = new System.Drawing.Point(292, 0);
               this.pnl_main.Name = "pnl_main";
               this.pnl_main.Size = new System.Drawing.Size(1046, 628);
               this.pnl_main.TabIndex = 3;
               // 
               // panel4
               // 
               this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
               this.panel4.Controls.Add(this.buttonX4);
               this.panel4.Controls.Add(this.comboBox1);
               this.panel4.Controls.Add(this.label2);
               this.panel4.Controls.Add(this.buttonX3);
               this.panel4.Controls.Add(this.buttonX2);
               this.panel4.Controls.Add(this.textBox2);
               this.panel4.Controls.Add(this.panel15);
               this.panel4.Controls.Add(this.dataGridView1);
               this.panel4.Controls.Add(this.label1);
               this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel4.Location = new System.Drawing.Point(0, 0);
               this.panel4.Name = "panel4";
               this.panel4.Size = new System.Drawing.Size(292, 628);
               this.panel4.TabIndex = 2;
               // 
               // buttonX4
               // 
               this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
               this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
               this.buttonX4.Location = new System.Drawing.Point(95, 584);
               this.buttonX4.Name = "buttonX4";
               this.buttonX4.Size = new System.Drawing.Size(105, 37);
               this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.buttonX4.TabIndex = 57;
               this.buttonX4.Text = "  Hiển Thị";
               // 
               // comboBox1
               // 
               this.comboBox1.FormattingEnabled = true;
               this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
               this.comboBox1.Location = new System.Drawing.Point(185, 547);
               this.comboBox1.Name = "comboBox1";
               this.comboBox1.Size = new System.Drawing.Size(48, 21);
               this.comboBox1.TabIndex = 56;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(23, 549);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(156, 18);
               this.label2.TabIndex = 55;
               this.label2.Text = "Số Camera Mỗi Hàng:";
               // 
               // buttonX3
               // 
               this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
               this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
               this.buttonX3.Location = new System.Drawing.Point(171, 494);
               this.buttonX3.Name = "buttonX3";
               this.buttonX3.Size = new System.Drawing.Size(105, 37);
               this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.buttonX3.TabIndex = 54;
               this.buttonX3.Text = "Lưu ";
               // 
               // buttonX2
               // 
               this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
               this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
               this.buttonX2.Location = new System.Drawing.Point(26, 494);
               this.buttonX2.Name = "buttonX2";
               this.buttonX2.Size = new System.Drawing.Size(105, 37);
               this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.buttonX2.TabIndex = 49;
               this.buttonX2.Text = "Tìm Kiếm";
               // 
               // textBox2
               // 
               this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
               this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox2.Location = new System.Drawing.Point(26, 462);
               this.textBox2.Multiline = true;
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(250, 20);
               this.textBox2.TabIndex = 53;
               this.textBox2.Text = "Lọc";
               // 
               // panel15
               // 
               this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel15.Location = new System.Drawing.Point(26, 482);
               this.panel15.Name = "panel15";
               this.panel15.Size = new System.Drawing.Size(250, 1);
               this.panel15.TabIndex = 52;
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(1, 29);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(291, 421);
               this.dataGridView1.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(120, 8);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(61, 18);
               this.label1.TabIndex = 0;
               this.label1.Text = "Camera";
               // 
               // usr_CameraView
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.pnl_main);
               this.Controls.Add(this.panel4);
               this.Name = "usr_CameraView";
               this.Size = new System.Drawing.Size(1338, 628);
               this.panel4.ResumeLayout(false);
               this.panel4.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel pnl_main;
          private System.Windows.Forms.Panel panel4;
          private DevComponents.DotNetBar.ButtonX buttonX4;
          private System.Windows.Forms.ComboBox comboBox1;
          private System.Windows.Forms.Label label2;
          private DevComponents.DotNetBar.ButtonX buttonX3;
          private DevComponents.DotNetBar.ButtonX buttonX2;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Panel panel15;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Label label1;
     }
}
