
namespace WindowsFormsApp1
{
     partial class usr_SingleCamera
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.txt_Status = new System.Windows.Forms.Button();
               this.txt_Location = new System.Windows.Forms.Button();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.txt_Location);
               this.panel1.Controls.Add(this.txt_Status);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel1.Location = new System.Drawing.Point(0, 172);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(307, 25);
               this.panel1.TabIndex = 0;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pictureBox1.Location = new System.Drawing.Point(0, 0);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(307, 172);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // txt_Status
               // 
               this.txt_Status.Dock = System.Windows.Forms.DockStyle.Left;
               this.txt_Status.Location = new System.Drawing.Point(0, 0);
               this.txt_Status.Name = "txt_Status";
               this.txt_Status.Size = new System.Drawing.Size(57, 25);
               this.txt_Status.TabIndex = 0;
               this.txt_Status.Text = "Bật";
               this.txt_Status.UseVisualStyleBackColor = true;
               // 
               // txt_Location
               // 
               this.txt_Location.Dock = System.Windows.Forms.DockStyle.Right;
               this.txt_Location.Location = new System.Drawing.Point(250, 0);
               this.txt_Location.Name = "txt_Location";
               this.txt_Location.Size = new System.Drawing.Size(57, 25);
               this.txt_Location.TabIndex = 1;
               this.txt_Location.Text = "Vị Trí:";
               this.txt_Location.UseVisualStyleBackColor = true;
               // 
               // usr_SingleCamera
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.panel1);
               this.Name = "usr_SingleCamera";
               this.Size = new System.Drawing.Size(307, 197);
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.Button txt_Location;
          private System.Windows.Forms.Button txt_Status;
     }
}
