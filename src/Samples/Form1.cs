using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using HD.MyControls;

namespace Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private VistaButton vistaButton1;
		private VistaButton vistaButton2;
		private VistaButton vistaButton3;
		private VistaButton vistaButton4;
		private VistaButton vistaButton5;
		private VistaButton vistaButton6;
		private VistaButton vistaButton7;
        private VistaButton vistaButton8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vistaButton1 = new HD.MyControls.VistaButton();
            this.vistaButton2 = new HD.MyControls.VistaButton();
            this.vistaButton3 = new HD.MyControls.VistaButton();
            this.vistaButton4 = new HD.MyControls.VistaButton();
            this.vistaButton5 = new HD.MyControls.VistaButton();
            this.vistaButton6 = new HD.MyControls.VistaButton();
            this.vistaButton7 = new HD.MyControls.VistaButton();
            this.vistaButton8 = new HD.MyControls.VistaButton();
            this.SuspendLayout();
            // 
            // vistaButton1
            // 
            this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton1.ButtonText = "Default";
            this.vistaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton1.Location = new System.Drawing.Point(48, 9);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(163, 43);
            this.vistaButton1.TabIndex = 0;
            // 
            // vistaButton2
            // 
            this.vistaButton2.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton2.BackImage = ((System.Drawing.Image)(resources.GetObject("vistaButton2.BackImage")));
            this.vistaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton2.ButtonText = "Image";
            this.vistaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton2.Location = new System.Drawing.Point(250, 9);
            this.vistaButton2.Name = "vistaButton2";
            this.vistaButton2.Size = new System.Drawing.Size(153, 43);
            this.vistaButton2.TabIndex = 0;
            // 
            // vistaButton3
            // 
            this.vistaButton3.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
            this.vistaButton3.ButtonStyle = HD.MyControls.VistaButton.Style.Flat;
            this.vistaButton3.ButtonText = "Yes (hover)";
            this.vistaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton3.Image = ((System.Drawing.Image)(resources.GetObject("vistaButton3.Image")));
            this.vistaButton3.Location = new System.Drawing.Point(48, 103);
            this.vistaButton3.Name = "vistaButton3";
            this.vistaButton3.Size = new System.Drawing.Size(163, 43);
            this.vistaButton3.TabIndex = 0;
            // 
            // vistaButton4
            // 
            this.vistaButton4.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vistaButton4.ButtonStyle = HD.MyControls.VistaButton.Style.Flat;
            this.vistaButton4.ButtonText = "No (hover)";
            this.vistaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton4.Image = ((System.Drawing.Image)(resources.GetObject("vistaButton4.Image")));
            this.vistaButton4.Location = new System.Drawing.Point(250, 103);
            this.vistaButton4.Name = "vistaButton4";
            this.vistaButton4.Size = new System.Drawing.Size(163, 43);
            this.vistaButton4.TabIndex = 0;
            // 
            // vistaButton5
            // 
            this.vistaButton5.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton5.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.vistaButton5.ButtonText = "Transparent";
            this.vistaButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton5.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.vistaButton5.Location = new System.Drawing.Point(250, 198);
            this.vistaButton5.Name = "vistaButton5";
            this.vistaButton5.Size = new System.Drawing.Size(163, 43);
            this.vistaButton5.TabIndex = 0;
            this.vistaButton5.Click += new System.EventHandler(this.vistaButton5_Click);
            // 
            // vistaButton6
            // 
            this.vistaButton6.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton6.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton6.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.vistaButton6.ButtonText = "Transparent";
            this.vistaButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton6.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vistaButton6.Location = new System.Drawing.Point(48, 198);
            this.vistaButton6.Name = "vistaButton6";
            this.vistaButton6.Size = new System.Drawing.Size(163, 43);
            this.vistaButton6.TabIndex = 0;
            // 
            // vistaButton7
            // 
            this.vistaButton7.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton7.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton7.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
            this.vistaButton7.ButtonText = "Rounded Corners";
            this.vistaButton7.CornerRadius = 20;
            this.vistaButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton7.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.vistaButton7.Location = new System.Drawing.Point(48, 310);
            this.vistaButton7.Name = "vistaButton7";
            this.vistaButton7.Size = new System.Drawing.Size(163, 43);
            this.vistaButton7.TabIndex = 0;
            // 
            // vistaButton8
            // 
            this.vistaButton8.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton8.BaseColor = System.Drawing.Color.Transparent;
            this.vistaButton8.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vistaButton8.ButtonText = "Sharp Corners";
            this.vistaButton8.CornerRadius = 0;
            this.vistaButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistaButton8.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(189)))));
            this.vistaButton8.Location = new System.Drawing.Point(250, 310);
            this.vistaButton8.Name = "vistaButton8";
            this.vistaButton8.Size = new System.Drawing.Size(163, 43);
            this.vistaButton8.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 425);
            this.Controls.Add(this.vistaButton1);
            this.Controls.Add(this.vistaButton2);
            this.Controls.Add(this.vistaButton3);
            this.Controls.Add(this.vistaButton4);
            this.Controls.Add(this.vistaButton5);
            this.Controls.Add(this.vistaButton6);
            this.Controls.Add(this.vistaButton7);
            this.Controls.Add(this.vistaButton8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vista Button Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

        private void vistaButton5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
	}
}
