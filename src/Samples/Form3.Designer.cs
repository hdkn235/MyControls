namespace Samples
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControlEx2 = new HD.MyControls.TabControlEx();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControlEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 59);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 59);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = 0;
            this.tabPage2.Text = "系统";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "application-sidebar.png");
            this.imageList.Images.SetKeyName(1, "color-swatch.png");
            this.imageList.Images.SetKeyName(2, "blue-document-text.png");
            this.imageList.Images.SetKeyName(3, "calendar-blue.png");
            this.imageList.Images.SetKeyName(4, "clock.png");
            this.imageList.Images.SetKeyName(5, "color.png");
            this.imageList.Images.SetKeyName(6, "keyboard.png");
            // 
            // tabControlEx2
            // 
            this.tabControlEx2.Controls.Add(this.tabPage3);
            this.tabControlEx2.Controls.Add(this.tabPage4);
            this.tabControlEx2.Controls.Add(this.tabPage5);
            this.tabControlEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEx2.Image = ((System.Drawing.Image)(resources.GetObject("tabControlEx2.Image")));
            this.tabControlEx2.ImageList = this.imageList;
            this.tabControlEx2.ItemSize = new System.Drawing.Size(50, 55);
            this.tabControlEx2.Location = new System.Drawing.Point(0, 0);
            this.tabControlEx2.Name = "tabControlEx2";
            this.tabControlEx2.SelectedIndex = 0;
            this.tabControlEx2.Size = new System.Drawing.Size(447, 349);
            this.tabControlEx2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 59);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(439, 286);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Tag = 0;
            this.tabPage3.Text = "常规";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageIndex = 1;
            this.tabPage4.Location = new System.Drawing.Point(4, 59);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(439, 286);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Tag = 0;
            this.tabPage4.Text = "外观";
            // 
            // tabPage5
            // 
            this.tabPage5.ImageIndex = 2;
            this.tabPage5.Location = new System.Drawing.Point(4, 59);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(439, 286);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Tag = 0;
            this.tabPage5.Text = "书签";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 349);
            this.Controls.Add(this.tabControlEx2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControlEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HD.MyControls.TabControlEx tabControlEx1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList;
        private HD.MyControls.TabControlEx tabControlEx2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}