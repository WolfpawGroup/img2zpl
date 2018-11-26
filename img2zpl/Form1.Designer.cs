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
			this.components = new System.ComponentModel.Container();
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
			this.cb_Resize = new System.Windows.Forms.CheckBox();
			this.btn_OriginalSize = new System.Windows.Forms.Button();
			this.p_Resize = new System.Windows.Forms.Panel();
			this.cb_LockAspectRatio = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.num_Resize_Height = new System.Windows.Forms.NumericUpDown();
			this.num_Resize_Width = new System.Windows.Forms.NumericUpDown();
			this.btn_Settings = new System.Windows.Forms.Button();
			this.cm_Settings = new img2zpl.myCM();
			this.tst_SettingsTitle = new System.Windows.Forms.ToolStripTextBox();
			this.tts_Sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_AddHeaderFooter = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_CompressHex = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_SeparateToLines = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_GenerateAsPerlCode = new System.Windows.Forms.ToolStripMenuItem();
			this.tt_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tts_Sep2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_LoadLastImage = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Misc = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Misc_Font = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Misc_FGColor = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Misc_BGColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_Help = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
			this.p_Resize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Width)).BeginInit();
			this.cm_Settings.SuspendLayout();
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
			this.tb_ImagePath.Size = new System.Drawing.Size(242, 20);
			this.tb_ImagePath.TabIndex = 1;
			this.tt_ToolTip.SetToolTip(this.tb_ImagePath, "Image Path");
			// 
			// btn_LoadImage
			// 
			this.btn_LoadImage.Location = new System.Drawing.Point(308, 4);
			this.btn_LoadImage.Name = "btn_LoadImage";
			this.btn_LoadImage.Size = new System.Drawing.Size(75, 23);
			this.btn_LoadImage.TabIndex = 2;
			this.btn_LoadImage.Text = "Load";
			this.tt_ToolTip.SetToolTip(this.btn_LoadImage, "Load a new image");
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
			this.pb_Image.Size = new System.Drawing.Size(368, 156);
			this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image.TabIndex = 3;
			this.pb_Image.TabStop = false;
			this.tt_ToolTip.SetToolTip(this.pb_Image, "Image (Drag to load)");
			this.pb_Image.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragDrop);
			this.pb_Image.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragEnter);
			this.pb_Image.DragOver += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragOver);
			// 
			// btn_Image_Copy
			// 
			this.btn_Image_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Image_Copy.Location = new System.Drawing.Point(15, 196);
			this.btn_Image_Copy.Name = "btn_Image_Copy";
			this.btn_Image_Copy.Size = new System.Drawing.Size(75, 23);
			this.btn_Image_Copy.TabIndex = 4;
			this.btn_Image_Copy.Text = "Copy";
			this.tt_ToolTip.SetToolTip(this.btn_Image_Copy, "Copy image to clipboard");
			this.btn_Image_Copy.UseVisualStyleBackColor = true;
			this.btn_Image_Copy.Click += new System.EventHandler(this.btn_Image_Copy_Click);
			// 
			// btn_Image_Save
			// 
			this.btn_Image_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Image_Save.Location = new System.Drawing.Point(96, 196);
			this.btn_Image_Save.Name = "btn_Image_Save";
			this.btn_Image_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Image_Save.TabIndex = 5;
			this.btn_Image_Save.Text = "Save";
			this.tt_ToolTip.SetToolTip(this.btn_Image_Save, "Save image to file");
			this.btn_Image_Save.UseVisualStyleBackColor = true;
			this.btn_Image_Save.Click += new System.EventHandler(this.btn_Image_Save_Click);
			// 
			// btn_ConvertToZebra
			// 
			this.btn_ConvertToZebra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ConvertToZebra.Location = new System.Drawing.Point(258, 196);
			this.btn_ConvertToZebra.Name = "btn_ConvertToZebra";
			this.btn_ConvertToZebra.Size = new System.Drawing.Size(125, 23);
			this.btn_ConvertToZebra.TabIndex = 6;
			this.btn_ConvertToZebra.Text = "Convert →";
			this.tt_ToolTip.SetToolTip(this.btn_ConvertToZebra, "Generate ZPL code from image");
			this.btn_ConvertToZebra.UseVisualStyleBackColor = true;
			this.btn_ConvertToZebra.Click += new System.EventHandler(this.btn_ConvertToZebra_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Location = new System.Drawing.Point(389, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 232);
			this.panel1.TabIndex = 7;
			// 
			// rtb_Zebra
			// 
			this.rtb_Zebra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Zebra.Location = new System.Drawing.Point(398, 34);
			this.rtb_Zebra.Name = "rtb_Zebra";
			this.rtb_Zebra.Size = new System.Drawing.Size(374, 156);
			this.rtb_Zebra.TabIndex = 8;
			this.rtb_Zebra.Text = "";
			this.tt_ToolTip.SetToolTip(this.rtb_Zebra, "ZPL Code");
			this.rtb_Zebra.Click += new System.EventHandler(this.rtb_Zebra_Click);
			// 
			// btn_ConvertToImage
			// 
			this.btn_ConvertToImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ConvertToImage.Location = new System.Drawing.Point(398, 196);
			this.btn_ConvertToImage.Name = "btn_ConvertToImage";
			this.btn_ConvertToImage.Size = new System.Drawing.Size(100, 23);
			this.btn_ConvertToImage.TabIndex = 9;
			this.btn_ConvertToImage.Text = "← Convert";
			this.tt_ToolTip.SetToolTip(this.btn_ConvertToImage, "Generate image from the ZPL code (Only image without other data)");
			this.btn_ConvertToImage.UseVisualStyleBackColor = true;
			// 
			// btn_Zebra_Copy
			// 
			this.btn_Zebra_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Copy.Location = new System.Drawing.Point(560, 196);
			this.btn_Zebra_Copy.Name = "btn_Zebra_Copy";
			this.btn_Zebra_Copy.Size = new System.Drawing.Size(48, 23);
			this.btn_Zebra_Copy.TabIndex = 10;
			this.btn_Zebra_Copy.Text = "Copy";
			this.tt_ToolTip.SetToolTip(this.btn_Zebra_Copy, "Copy ZPL code to clipboard");
			this.btn_Zebra_Copy.UseVisualStyleBackColor = true;
			this.btn_Zebra_Copy.Click += new System.EventHandler(this.btn_Zebra_Copy_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Exit.Location = new System.Drawing.Point(686, 196);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(86, 23);
			this.btn_Exit.TabIndex = 11;
			this.btn_Exit.Text = "Exit";
			this.tt_ToolTip.SetToolTip(this.btn_Exit, "Exit IMG2ZPL");
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Zebra_Save
			// 
			this.btn_Zebra_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Save.Location = new System.Drawing.Point(506, 196);
			this.btn_Zebra_Save.Name = "btn_Zebra_Save";
			this.btn_Zebra_Save.Size = new System.Drawing.Size(48, 23);
			this.btn_Zebra_Save.TabIndex = 12;
			this.btn_Zebra_Save.Text = "Save";
			this.tt_ToolTip.SetToolTip(this.btn_Zebra_Save, "Save ZPL code to file");
			this.btn_Zebra_Save.UseVisualStyleBackColor = true;
			this.btn_Zebra_Save.Click += new System.EventHandler(this.btn_Zebra_Save_Click);
			// 
			// btn_preview
			// 
			this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_preview.Location = new System.Drawing.Point(614, 196);
			this.btn_preview.Name = "btn_preview";
			this.btn_preview.Size = new System.Drawing.Size(55, 23);
			this.btn_preview.TabIndex = 13;
			this.btn_preview.Text = "Preview";
			this.tt_ToolTip.SetToolTip(this.btn_preview, "Preview ZPL code");
			this.btn_preview.UseVisualStyleBackColor = true;
			this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
			// 
			// cb_Resize
			// 
			this.cb_Resize.AutoSize = true;
			this.cb_Resize.Location = new System.Drawing.Point(439, 8);
			this.cb_Resize.Name = "cb_Resize";
			this.cb_Resize.Size = new System.Drawing.Size(89, 17);
			this.cb_Resize.TabIndex = 16;
			this.cb_Resize.Text = "Resize image";
			this.tt_ToolTip.SetToolTip(this.cb_Resize, "Resize Image when generating ZPL code");
			this.cb_Resize.UseVisualStyleBackColor = true;
			this.cb_Resize.CheckedChanged += new System.EventHandler(this.cb_Resize_CheckedChanged);
			// 
			// btn_OriginalSize
			// 
			this.btn_OriginalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_OriginalSize.Location = new System.Drawing.Point(177, 196);
			this.btn_OriginalSize.Name = "btn_OriginalSize";
			this.btn_OriginalSize.Size = new System.Drawing.Size(75, 23);
			this.btn_OriginalSize.TabIndex = 20;
			this.btn_OriginalSize.Text = "Original Size";
			this.tt_ToolTip.SetToolTip(this.btn_OriginalSize, "Reset the original image size");
			this.btn_OriginalSize.UseVisualStyleBackColor = true;
			this.btn_OriginalSize.Click += new System.EventHandler(this.btn_OriginalSize_Click);
			// 
			// p_Resize
			// 
			this.p_Resize.Controls.Add(this.cb_LockAspectRatio);
			this.p_Resize.Controls.Add(this.label2);
			this.p_Resize.Controls.Add(this.num_Resize_Height);
			this.p_Resize.Controls.Add(this.num_Resize_Width);
			this.p_Resize.Enabled = false;
			this.p_Resize.Location = new System.Drawing.Point(524, 1);
			this.p_Resize.Name = "p_Resize";
			this.p_Resize.Size = new System.Drawing.Size(222, 27);
			this.p_Resize.TabIndex = 21;
			// 
			// cb_LockAspectRatio
			// 
			this.cb_LockAspectRatio.AutoSize = true;
			this.cb_LockAspectRatio.Location = new System.Drawing.Point(137, 7);
			this.cb_LockAspectRatio.Name = "cb_LockAspectRatio";
			this.cb_LockAspectRatio.Size = new System.Drawing.Size(78, 17);
			this.cb_LockAspectRatio.TabIndex = 23;
			this.cb_LockAspectRatio.Text = "Lock Ratio";
			this.tt_ToolTip.SetToolTip(this.cb_LockAspectRatio, "Lock aspect ration between with and height of image when resizing");
			this.cb_LockAspectRatio.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "X";
			// 
			// num_Resize_Height
			// 
			this.num_Resize_Height.Location = new System.Drawing.Point(78, 6);
			this.num_Resize_Height.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.num_Resize_Height.Name = "num_Resize_Height";
			this.num_Resize_Height.Size = new System.Drawing.Size(55, 20);
			this.num_Resize_Height.TabIndex = 21;
			this.tt_ToolTip.SetToolTip(this.num_Resize_Height, "Resized Height (px)");
			// 
			// num_Resize_Width
			// 
			this.num_Resize_Width.Location = new System.Drawing.Point(4, 6);
			this.num_Resize_Width.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.num_Resize_Width.Name = "num_Resize_Width";
			this.num_Resize_Width.Size = new System.Drawing.Size(55, 20);
			this.num_Resize_Width.TabIndex = 20;
			this.tt_ToolTip.SetToolTip(this.num_Resize_Width, "Resized Width (px)");
			// 
			// btn_Settings
			// 
			this.btn_Settings.BackgroundImage = global::img2zpl.Properties.Resources.gear_1;
			this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Settings.FlatAppearance.BorderSize = 0;
			this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Settings.Location = new System.Drawing.Point(398, 4);
			this.btn_Settings.Name = "btn_Settings";
			this.btn_Settings.Size = new System.Drawing.Size(24, 24);
			this.btn_Settings.TabIndex = 22;
			this.tt_ToolTip.SetToolTip(this.btn_Settings, "Settings");
			this.btn_Settings.UseVisualStyleBackColor = true;
			this.btn_Settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Settings_MouseClick);
			// 
			// cm_Settings
			// 
			this.cm_Settings.AutoClose = false;
			this.cm_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_SettingsTitle,
            this.tts_Sep1,
            this.btn_Settings_AddHeaderFooter,
            this.btn_Settings_CompressHex,
            this.btn_Settings_SeparateToLines,
            this.btn_Settings_GenerateAsPerlCode,
            this.tts_Sep2,
            this.btn_Settings_LoadLastImage,
            this.tts_Sep3,
            this.btn_Settings_Misc});
			this.cm_Settings.Name = "cm_Settings";
			this.cm_Settings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.cm_Settings.ShowCheckMargin = true;
			this.cm_Settings.ShowImageMargin = false;
			this.cm_Settings.Size = new System.Drawing.Size(217, 171);
			this.cm_Settings.Text = "--- SETTINGS ---";
			this.cm_Settings.Opening += new System.ComponentModel.CancelEventHandler(this.cm_Settings_Opening);
			this.cm_Settings.MouseLeave += new System.EventHandler(this.cm_Settings_MouseLeave);
			// 
			// tst_SettingsTitle
			// 
			this.tst_SettingsTitle.BackColor = System.Drawing.Color.White;
			this.tst_SettingsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tst_SettingsTitle.Enabled = false;
			this.tst_SettingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tst_SettingsTitle.Name = "tst_SettingsTitle";
			this.tst_SettingsTitle.ReadOnly = true;
			this.tst_SettingsTitle.Size = new System.Drawing.Size(100, 15);
			this.tst_SettingsTitle.Text = "--- SETTINGS ---";
			this.tst_SettingsTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tts_Sep1
			// 
			this.tts_Sep1.BackColor = System.Drawing.Color.Coral;
			this.tts_Sep1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tts_Sep1.Name = "tts_Sep1";
			this.tts_Sep1.Size = new System.Drawing.Size(213, 6);
			// 
			// btn_Settings_AddHeaderFooter
			// 
			this.btn_Settings_AddHeaderFooter.CheckOnClick = true;
			this.btn_Settings_AddHeaderFooter.Name = "btn_Settings_AddHeaderFooter";
			this.btn_Settings_AddHeaderFooter.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_AddHeaderFooter.Tag = "ahf";
			this.btn_Settings_AddHeaderFooter.Text = "Add ZPL header and footer";
			this.btn_Settings_AddHeaderFooter.ToolTipText = "Add ZPL header and footer commands around the generated image code";
			this.btn_Settings_AddHeaderFooter.Click += new System.EventHandler(this.btn_Settings_AddHeaderFooter_Click);
			// 
			// btn_Settings_CompressHex
			// 
			this.btn_Settings_CompressHex.CheckOnClick = true;
			this.btn_Settings_CompressHex.Name = "btn_Settings_CompressHex";
			this.btn_Settings_CompressHex.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_CompressHex.Tag = "cih";
			this.btn_Settings_CompressHex.Text = "Compress image HEX";
			this.btn_Settings_CompressHex.ToolTipText = "Use the ZPL II Hex image compression model to compress the HEX data generated for" +
    "m the image";
			this.btn_Settings_CompressHex.Click += new System.EventHandler(this.btn_Settings_CompressHex_Click);
			// 
			// btn_Settings_SeparateToLines
			// 
			this.btn_Settings_SeparateToLines.CheckOnClick = true;
			this.btn_Settings_SeparateToLines.Name = "btn_Settings_SeparateToLines";
			this.btn_Settings_SeparateToLines.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_SeparateToLines.Tag = "i2l";
			this.btn_Settings_SeparateToLines.Text = "Separate image to lines";
			this.btn_Settings_SeparateToLines.ToolTipText = "After every line of the image add a new line character in the generated code (\\n)" +
    "";
			this.btn_Settings_SeparateToLines.Click += new System.EventHandler(this.btn_Settings_SeparateToLines_Click);
			// 
			// btn_Settings_GenerateAsPerlCode
			// 
			this.btn_Settings_GenerateAsPerlCode.CheckOnClick = true;
			this.btn_Settings_GenerateAsPerlCode.Name = "btn_Settings_GenerateAsPerlCode";
			this.btn_Settings_GenerateAsPerlCode.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_GenerateAsPerlCode.Tag = "gpc";
			this.btn_Settings_GenerateAsPerlCode.Text = "Generate as PERL code";
			this.btn_Settings_GenerateAsPerlCode.ToolTipText = "Generate the outpout in the PERL script language";
			this.btn_Settings_GenerateAsPerlCode.Click += new System.EventHandler(this.btn_Settings_GenerateAsPerlCode_Click);
			// 
			// tts_Sep2
			// 
			this.tts_Sep2.Name = "tts_Sep2";
			this.tts_Sep2.Size = new System.Drawing.Size(213, 6);
			// 
			// btn_Settings_LoadLastImage
			// 
			this.btn_Settings_LoadLastImage.Name = "btn_Settings_LoadLastImage";
			this.btn_Settings_LoadLastImage.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_LoadLastImage.Text = "Load last image";
			this.btn_Settings_LoadLastImage.ToolTipText = "Load the last image that waas opened in this tool";
			this.btn_Settings_LoadLastImage.Click += new System.EventHandler(this.btn_Settings_LoadLastImage_Click);
			// 
			// tts_Sep3
			// 
			this.tts_Sep3.Name = "tts_Sep3";
			this.tts_Sep3.Size = new System.Drawing.Size(213, 6);
			// 
			// btn_Settings_Misc
			// 
			this.btn_Settings_Misc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Settings_Misc_Font,
            this.btn_Settings_Misc_FGColor,
            this.btn_Settings_Misc_BGColor});
			this.btn_Settings_Misc.Name = "btn_Settings_Misc";
			this.btn_Settings_Misc.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_Misc.Text = "Misc Settings";
			this.btn_Settings_Misc.DropDownOpening += new System.EventHandler(this.btn_Settings_Misc_DropDownOpening);
			// 
			// btn_Settings_Misc_Font
			// 
			this.btn_Settings_Misc_Font.Name = "btn_Settings_Misc_Font";
			this.btn_Settings_Misc_Font.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Misc_Font.Text = "Font";
			this.btn_Settings_Misc_Font.ToolTipText = "The font used for the ZPL code";
			this.btn_Settings_Misc_Font.Click += new System.EventHandler(this.btn_Settings_Misc_Font_Click);
			// 
			// btn_Settings_Misc_FGColor
			// 
			this.btn_Settings_Misc_FGColor.Name = "btn_Settings_Misc_FGColor";
			this.btn_Settings_Misc_FGColor.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Misc_FGColor.Text = "Foreground Color";
			this.btn_Settings_Misc_FGColor.ToolTipText = "Foreground color of the ZPL code text area";
			this.btn_Settings_Misc_FGColor.Click += new System.EventHandler(this.btn_Settings_Misc_FGColor_Click);
			// 
			// btn_Settings_Misc_BGColor
			// 
			this.btn_Settings_Misc_BGColor.Name = "btn_Settings_Misc_BGColor";
			this.btn_Settings_Misc_BGColor.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Misc_BGColor.Text = "Background Color";
			this.btn_Settings_Misc_BGColor.ToolTipText = "Background color of the ZPL code text area";
			this.btn_Settings_Misc_BGColor.Click += new System.EventHandler(this.btn_Settings_Misc_BGColor_Click);
			// 
			// cb_Help
			// 
			this.cb_Help.AutoSize = true;
			this.cb_Help.Location = new System.Drawing.Point(746, 8);
			this.cb_Help.Name = "cb_Help";
			this.cb_Help.Size = new System.Drawing.Size(32, 17);
			this.cb_Help.TabIndex = 23;
			this.cb_Help.Text = "?";
			this.cb_Help.UseVisualStyleBackColor = true;
			this.cb_Help.CheckedChanged += new System.EventHandler(this.cb_Help_CheckedChanged);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 226);
			this.Controls.Add(this.cb_Help);
			this.Controls.Add(this.btn_Settings);
			this.Controls.Add(this.p_Resize);
			this.Controls.Add(this.btn_OriginalSize);
			this.Controls.Add(this.cb_Resize);
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
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.LocationChanged += new System.EventHandler(this.Form1_ResizeEnd);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
			this.p_Resize.ResumeLayout(false);
			this.p_Resize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Width)).EndInit();
			this.cm_Settings.ResumeLayout(false);
			this.cm_Settings.PerformLayout();
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
		private System.Windows.Forms.CheckBox cb_Resize;
		private System.Windows.Forms.Button btn_OriginalSize;
		private System.Windows.Forms.Panel p_Resize;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown num_Resize_Height;
		private System.Windows.Forms.NumericUpDown num_Resize_Width;
		private System.Windows.Forms.Button btn_Settings;
		private System.Windows.Forms.CheckBox cb_LockAspectRatio;
		private myCM cm_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_AddHeaderFooter;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_CompressHex;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_SeparateToLines;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_GenerateAsPerlCode;
		private System.Windows.Forms.ToolStripSeparator tts_Sep1;
		private System.Windows.Forms.ToolStripTextBox tst_SettingsTitle;
		private System.Windows.Forms.ToolTip tt_ToolTip;
		private System.Windows.Forms.ToolStripSeparator tts_Sep2;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_LoadLastImage;
		private System.Windows.Forms.ToolStripSeparator tts_Sep3;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_Font;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_FGColor;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_BGColor;
		private System.Windows.Forms.CheckBox cb_Help;
	}
}

