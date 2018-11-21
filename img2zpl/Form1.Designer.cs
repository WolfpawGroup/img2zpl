namespace img2zpl
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_ImagePath = new System.Windows.Forms.TextBox();
			this.btn_LoadImage = new System.Windows.Forms.Button();
			this.pb_Image = new System.Windows.Forms.PictureBox();
			this.btn_Image_Copy = new System.Windows.Forms.Button();
			this.btn_Image_Save = new System.Windows.Forms.Button();
			this.btn_ConvertToZebra = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rtb_Zebra = new System.Windows.Forms.RichTextBox();
			this.btn_ConvertToImage = new System.Windows.Forms.Button();
			this.btn_Zebra_Copy = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Zebra_Save = new System.Windows.Forms.Button();
			this.btn_preview = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Image: ";
			// 
			// tb_ImagePath
			// 
			this.tb_ImagePath.Location = new System.Drawing.Point(60, 6);
			this.tb_ImagePath.Name = "tb_ImagePath";
			this.tb_ImagePath.Size = new System.Drawing.Size(267, 20);
			this.tb_ImagePath.TabIndex = 1;
			// 
			// btn_LoadImage
			// 
			this.btn_LoadImage.Location = new System.Drawing.Point(333, 4);
			this.btn_LoadImage.Name = "btn_LoadImage";
			this.btn_LoadImage.Size = new System.Drawing.Size(75, 23);
			this.btn_LoadImage.TabIndex = 2;
			this.btn_LoadImage.Text = "Load";
			this.btn_LoadImage.UseVisualStyleBackColor = true;
			this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
			// 
			// pb_Image
			// 
			this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pb_Image.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pb_Image.Location = new System.Drawing.Point(15, 34);
			this.pb_Image.Name = "pb_Image";
			this.pb_Image.Size = new System.Drawing.Size(392, 279);
			this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image.TabIndex = 3;
			this.pb_Image.TabStop = false;
			this.pb_Image.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragDrop);
			this.pb_Image.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragEnter);
			this.pb_Image.DragOver += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragOver);
			// 
			// btn_Image_Copy
			// 
			this.btn_Image_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Image_Copy.Location = new System.Drawing.Point(15, 319);
			this.btn_Image_Copy.Name = "btn_Image_Copy";
			this.btn_Image_Copy.Size = new System.Drawing.Size(75, 23);
			this.btn_Image_Copy.TabIndex = 4;
			this.btn_Image_Copy.Text = "Copy";
			this.btn_Image_Copy.UseVisualStyleBackColor = true;
			this.btn_Image_Copy.Click += new System.EventHandler(this.btn_Image_Copy_Click);
			// 
			// btn_Image_Save
			// 
			this.btn_Image_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Image_Save.Location = new System.Drawing.Point(96, 319);
			this.btn_Image_Save.Name = "btn_Image_Save";
			this.btn_Image_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Image_Save.TabIndex = 5;
			this.btn_Image_Save.Text = "Save";
			this.btn_Image_Save.UseVisualStyleBackColor = true;
			this.btn_Image_Save.Click += new System.EventHandler(this.btn_Image_Save_Click);
			// 
			// btn_ConvertToZebra
			// 
			this.btn_ConvertToZebra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ConvertToZebra.Location = new System.Drawing.Point(177, 319);
			this.btn_ConvertToZebra.Name = "btn_ConvertToZebra";
			this.btn_ConvertToZebra.Size = new System.Drawing.Size(230, 23);
			this.btn_ConvertToZebra.TabIndex = 6;
			this.btn_ConvertToZebra.Text = "Convert →";
			this.btn_ConvertToZebra.UseVisualStyleBackColor = true;
			this.btn_ConvertToZebra.Click += new System.EventHandler(this.btn_ConvertToZebra_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Location = new System.Drawing.Point(413, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 355);
			this.panel1.TabIndex = 7;
			// 
			// rtb_Zebra
			// 
			this.rtb_Zebra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Zebra.Location = new System.Drawing.Point(422, 4);
			this.rtb_Zebra.Name = "rtb_Zebra";
			this.rtb_Zebra.Size = new System.Drawing.Size(585, 309);
			this.rtb_Zebra.TabIndex = 8;
			this.rtb_Zebra.Text = "";
			// 
			// btn_ConvertToImage
			// 
			this.btn_ConvertToImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ConvertToImage.Location = new System.Drawing.Point(422, 319);
			this.btn_ConvertToImage.Name = "btn_ConvertToImage";
			this.btn_ConvertToImage.Size = new System.Drawing.Size(100, 23);
			this.btn_ConvertToImage.TabIndex = 9;
			this.btn_ConvertToImage.Text = "← Convert";
			this.btn_ConvertToImage.UseVisualStyleBackColor = true;
			// 
			// btn_Zebra_Copy
			// 
			this.btn_Zebra_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Copy.Location = new System.Drawing.Point(582, 319);
			this.btn_Zebra_Copy.Name = "btn_Zebra_Copy";
			this.btn_Zebra_Copy.Size = new System.Drawing.Size(48, 23);
			this.btn_Zebra_Copy.TabIndex = 10;
			this.btn_Zebra_Copy.Text = "Copy";
			this.btn_Zebra_Copy.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Exit.Location = new System.Drawing.Point(932, 319);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 11;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// btn_Zebra_Save
			// 
			this.btn_Zebra_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Save.Location = new System.Drawing.Point(528, 319);
			this.btn_Zebra_Save.Name = "btn_Zebra_Save";
			this.btn_Zebra_Save.Size = new System.Drawing.Size(48, 23);
			this.btn_Zebra_Save.TabIndex = 12;
			this.btn_Zebra_Save.Text = "Save";
			this.btn_Zebra_Save.UseVisualStyleBackColor = true;
			// 
			// btn_preview
			// 
			this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_preview.Location = new System.Drawing.Point(636, 319);
			this.btn_preview.Name = "btn_preview";
			this.btn_preview.Size = new System.Drawing.Size(55, 23);
			this.btn_preview.TabIndex = 13;
			this.btn_preview.Text = "Preview";
			this.btn_preview.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 349);
			this.Controls.Add(this.btn_preview);
			this.Controls.Add(this.btn_Zebra_Save);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Zebra_Copy);
			this.Controls.Add(this.btn_ConvertToImage);
			this.Controls.Add(this.rtb_Zebra);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_ConvertToZebra);
			this.Controls.Add(this.btn_Image_Save);
			this.Controls.Add(this.btn_Image_Copy);
			this.Controls.Add(this.pb_Image);
			this.Controls.Add(this.btn_LoadImage);
			this.Controls.Add(this.tb_ImagePath);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(800, 200);
			this.Name = "Form1";
			this.Text = "WolfPaw Image to ZPL";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_ImagePath;
		private System.Windows.Forms.Button btn_LoadImage;
		private System.Windows.Forms.PictureBox pb_Image;
		private System.Windows.Forms.Button btn_Image_Copy;
		private System.Windows.Forms.Button btn_Image_Save;
		private System.Windows.Forms.Button btn_ConvertToZebra;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox rtb_Zebra;
		private System.Windows.Forms.Button btn_ConvertToImage;
		private System.Windows.Forms.Button btn_Zebra_Copy;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Zebra_Save;
		private System.Windows.Forms.Button btn_preview;
	}
}

