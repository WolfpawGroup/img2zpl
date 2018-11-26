namespace img2zpl
{
	partial class f_Preview
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pb_Image1 = new System.Windows.Forms.PictureBox();
			this.pb_Image2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image2)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pb_Image1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pb_Image2);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 370;
			this.splitContainer1.TabIndex = 0;
			// 
			// pb_Image1
			// 
			this.pb_Image1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pb_Image1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pb_Image1.Location = new System.Drawing.Point(0, 0);
			this.pb_Image1.Name = "pb_Image1";
			this.pb_Image1.Size = new System.Drawing.Size(370, 450);
			this.pb_Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image1.TabIndex = 0;
			this.pb_Image1.TabStop = false;
			// 
			// pb_Image2
			// 
			this.pb_Image2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pb_Image2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pb_Image2.Location = new System.Drawing.Point(0, 0);
			this.pb_Image2.Name = "pb_Image2";
			this.pb_Image2.Size = new System.Drawing.Size(426, 450);
			this.pb_Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image2.TabIndex = 1;
			this.pb_Image2.TabStop = false;
			// 
			// f_Preview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "f_Preview";
			this.Text = "Preview Window";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_Image1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pb_Image1;
		private System.Windows.Forms.PictureBox pb_Image2;
	}
}