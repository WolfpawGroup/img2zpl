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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.tb_ImagePath = new System.Windows.Forms.TextBox();
			this.btn_LoadImage = new System.Windows.Forms.Button();
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
			this.cm_Settings = new img2zpl.myCM();
			this.tst_SettingsTitle = new System.Windows.Forms.ToolStripTextBox();
			this.tts_Sep01 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_AddHeaderFooter = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_CompressHex = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_SeparateToLines = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_GenerateAsPerlCode = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep02 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_LoadLastImage = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep03 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer = new System.Windows.Forms.ToolStripMenuItem();
			this.tst_Settings_PrinterTitle = new System.Windows.Forms.ToolStripTextBox();
			this.tts_Sep07 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_Zebra = new System.Windows.Forms.ToolStripMenuItem();
			this.tst_Settings_Printer_ZebraTitle = new System.Windows.Forms.ToolStripTextBox();
			this.tts_Sep08 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_Zebra_Selection = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep09 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_Zebra_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Printer_Zebra_Setup = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Printer_Zebra_Preview = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep10 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_Zebra_Print = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Printer_General = new System.Windows.Forms.ToolStripMenuItem();
			this.tst_Settings_Printer_GeneralTitle = new System.Windows.Forms.ToolStripTextBox();
			this.tts_Sep11 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_General_Selection = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep12 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_General_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Printer_General_Setup = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Printer_General_Preview = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep13 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Printer_General_Print = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Misc = new System.Windows.Forms.ToolStripMenuItem();
			this.tst_Settings_MiscTitle = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Settings_Misc_Font = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep06 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Misc_FGColor = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Settings_Misc_BGColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep05 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Misc_InvertColors = new System.Windows.Forms.ToolStripMenuItem();
			this.tts_Sep04 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Settings_Misc_Reset = new System.Windows.Forms.ToolStripMenuItem();
			this.tt_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btn_Settings = new System.Windows.Forms.Button();
			this.pb_Image = new System.Windows.Forms.PictureBox();
			this.tb_Blackness = new System.Windows.Forms.TrackBar();
			this.btn_MoreMenu = new System.Windows.Forms.Button();
			this.btn_SendToPrinter = new System.Windows.Forms.Button();
			this.cb_Help = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_BlackLevelPercent = new System.Windows.Forms.Label();
			this.prnt_PageSetupDialog = new System.Windows.Forms.PageSetupDialog();
			this.prnt_PrintDocument = new System.Drawing.Printing.PrintDocument();
			this.prnt_PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.p_Resize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Width)).BeginInit();
			this.cm_Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_Blackness)).BeginInit();
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
			// btn_Image_Copy
			// 
			this.btn_Image_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Image_Copy.Location = new System.Drawing.Point(15, 221);
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
			this.btn_Image_Save.Location = new System.Drawing.Point(96, 221);
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
			this.btn_ConvertToZebra.Location = new System.Drawing.Point(258, 221);
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
			this.panel1.Size = new System.Drawing.Size(3, 257);
			this.panel1.TabIndex = 7;
			// 
			// rtb_Zebra
			// 
			this.rtb_Zebra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Zebra.Location = new System.Drawing.Point(398, 34);
			this.rtb_Zebra.Name = "rtb_Zebra";
			this.rtb_Zebra.Size = new System.Drawing.Size(376, 181);
			this.rtb_Zebra.TabIndex = 8;
			this.rtb_Zebra.Text = "";
			this.tt_ToolTip.SetToolTip(this.rtb_Zebra, "ZPL Code");
			this.rtb_Zebra.Click += new System.EventHandler(this.rtb_Zebra_Click);
			// 
			// btn_ConvertToImage
			// 
			this.btn_ConvertToImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ConvertToImage.Location = new System.Drawing.Point(398, 221);
			this.btn_ConvertToImage.Name = "btn_ConvertToImage";
			this.btn_ConvertToImage.Size = new System.Drawing.Size(100, 23);
			this.btn_ConvertToImage.TabIndex = 9;
			this.btn_ConvertToImage.Text = "← Convert";
			this.tt_ToolTip.SetToolTip(this.btn_ConvertToImage, "Generate image from the ZPL code (Only image without other data)");
			this.btn_ConvertToImage.UseVisualStyleBackColor = true;
			this.btn_ConvertToImage.Click += new System.EventHandler(this.btn_ConvertToImage_Click);
			// 
			// btn_Zebra_Copy
			// 
			this.btn_Zebra_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Copy.Location = new System.Drawing.Point(560, 221);
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
			this.btn_Exit.Location = new System.Drawing.Point(686, 221);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(88, 23);
			this.btn_Exit.TabIndex = 11;
			this.btn_Exit.Text = "Exit";
			this.tt_ToolTip.SetToolTip(this.btn_Exit, "Exit IMG2ZPL");
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Zebra_Save
			// 
			this.btn_Zebra_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Zebra_Save.Location = new System.Drawing.Point(506, 221);
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
			this.btn_preview.Location = new System.Drawing.Point(614, 221);
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
			this.btn_OriginalSize.Location = new System.Drawing.Point(177, 221);
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
			this.p_Resize.Size = new System.Drawing.Size(214, 27);
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
			this.num_Resize_Height.ValueChanged += new System.EventHandler(this.num_Resize_Height_ValueChanged);
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
			this.num_Resize_Width.ValueChanged += new System.EventHandler(this.num_Resize_Width_ValueChanged);
			// 
			// cm_Settings
			// 
			this.cm_Settings.AutoClose = false;
			this.cm_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_SettingsTitle,
            this.tts_Sep01,
            this.btn_Settings_AddHeaderFooter,
            this.btn_Settings_CompressHex,
            this.btn_Settings_SeparateToLines,
            this.btn_Settings_GenerateAsPerlCode,
            this.tts_Sep02,
            this.btn_Settings_LoadLastImage,
            this.tts_Sep03,
            this.btn_Settings_Printer,
            this.btn_Settings_Misc});
			this.cm_Settings.Name = "cm_Settings";
			this.cm_Settings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.cm_Settings.ShowCheckMargin = true;
			this.cm_Settings.ShowImageMargin = false;
			this.cm_Settings.Size = new System.Drawing.Size(217, 215);
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
			// tts_Sep01
			// 
			this.tts_Sep01.BackColor = System.Drawing.Color.Coral;
			this.tts_Sep01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tts_Sep01.Name = "tts_Sep01";
			this.tts_Sep01.Size = new System.Drawing.Size(213, 6);
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
			// tts_Sep02
			// 
			this.tts_Sep02.Name = "tts_Sep02";
			this.tts_Sep02.Size = new System.Drawing.Size(213, 6);
			// 
			// btn_Settings_LoadLastImage
			// 
			this.btn_Settings_LoadLastImage.Name = "btn_Settings_LoadLastImage";
			this.btn_Settings_LoadLastImage.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_LoadLastImage.Text = "Load last image";
			this.btn_Settings_LoadLastImage.ToolTipText = "Load the last image that waas opened in this tool";
			this.btn_Settings_LoadLastImage.Click += new System.EventHandler(this.btn_Settings_LoadLastImage_Click);
			// 
			// tts_Sep03
			// 
			this.tts_Sep03.Name = "tts_Sep03";
			this.tts_Sep03.Size = new System.Drawing.Size(213, 6);
			// 
			// btn_Settings_Printer
			// 
			this.btn_Settings_Printer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_Settings_PrinterTitle,
            this.tts_Sep07,
            this.btn_Settings_Printer_Zebra,
            this.btn_Settings_Printer_General});
			this.btn_Settings_Printer.Name = "btn_Settings_Printer";
			this.btn_Settings_Printer.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_Printer.Text = "Printer Settings";
			// 
			// tst_Settings_PrinterTitle
			// 
			this.tst_Settings_PrinterTitle.BackColor = System.Drawing.Color.White;
			this.tst_Settings_PrinterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tst_Settings_PrinterTitle.Enabled = false;
			this.tst_Settings_PrinterTitle.Name = "tst_Settings_PrinterTitle";
			this.tst_Settings_PrinterTitle.ReadOnly = true;
			this.tst_Settings_PrinterTitle.Size = new System.Drawing.Size(100, 16);
			this.tst_Settings_PrinterTitle.Text = "--- PRINTING ---";
			this.tst_Settings_PrinterTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tts_Sep07
			// 
			this.tts_Sep07.Name = "tts_Sep07";
			this.tts_Sep07.Size = new System.Drawing.Size(177, 6);
			// 
			// btn_Settings_Printer_Zebra
			// 
			this.btn_Settings_Printer_Zebra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_Settings_Printer_ZebraTitle,
            this.tts_Sep08,
            this.btn_Settings_Printer_Zebra_Selection,
            this.tts_Sep09,
            this.btn_Settings_Printer_Zebra_Settings,
            this.btn_Settings_Printer_Zebra_Setup,
            this.btn_Settings_Printer_Zebra_Preview,
            this.tts_Sep10,
            this.btn_Settings_Printer_Zebra_Print});
			this.btn_Settings_Printer_Zebra.Name = "btn_Settings_Printer_Zebra";
			this.btn_Settings_Printer_Zebra.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra.Text = "Zebra Printer";
			this.btn_Settings_Printer_Zebra.DropDownOpening += new System.EventHandler(this.btn_Settings_Printer_Zebra_DropDownOpening);
			// 
			// tst_Settings_Printer_ZebraTitle
			// 
			this.tst_Settings_Printer_ZebraTitle.BackColor = System.Drawing.Color.White;
			this.tst_Settings_Printer_ZebraTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tst_Settings_Printer_ZebraTitle.Enabled = false;
			this.tst_Settings_Printer_ZebraTitle.Name = "tst_Settings_Printer_ZebraTitle";
			this.tst_Settings_Printer_ZebraTitle.ReadOnly = true;
			this.tst_Settings_Printer_ZebraTitle.Size = new System.Drawing.Size(100, 16);
			this.tst_Settings_Printer_ZebraTitle.Text = "--- ZEBRA ---";
			this.tst_Settings_Printer_ZebraTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tts_Sep08
			// 
			this.tts_Sep08.Name = "tts_Sep08";
			this.tts_Sep08.Size = new System.Drawing.Size(177, 6);
			// 
			// btn_Settings_Printer_Zebra_Selection
			// 
			this.btn_Settings_Printer_Zebra_Selection.Name = "btn_Settings_Printer_Zebra_Selection";
			this.btn_Settings_Printer_Zebra_Selection.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra_Selection.Text = "Printer Selection";
			// 
			// tts_Sep09
			// 
			this.tts_Sep09.Name = "tts_Sep09";
			this.tts_Sep09.Size = new System.Drawing.Size(177, 6);
			// 
			// btn_Settings_Printer_Zebra_Settings
			// 
			this.btn_Settings_Printer_Zebra_Settings.Name = "btn_Settings_Printer_Zebra_Settings";
			this.btn_Settings_Printer_Zebra_Settings.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra_Settings.Text = "Printer Settings";
			// 
			// btn_Settings_Printer_Zebra_Setup
			// 
			this.btn_Settings_Printer_Zebra_Setup.Name = "btn_Settings_Printer_Zebra_Setup";
			this.btn_Settings_Printer_Zebra_Setup.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra_Setup.Text = "Page Setup";
			this.btn_Settings_Printer_Zebra_Setup.Click += new System.EventHandler(this.btn_Settings_Printer_Zebra_Setup_Click);
			// 
			// btn_Settings_Printer_Zebra_Preview
			// 
			this.btn_Settings_Printer_Zebra_Preview.Name = "btn_Settings_Printer_Zebra_Preview";
			this.btn_Settings_Printer_Zebra_Preview.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra_Preview.Text = "Print Preview";
			this.btn_Settings_Printer_Zebra_Preview.Click += new System.EventHandler(this.btn_Settings_Printer_Zebra_Preview_Click);
			// 
			// tts_Sep10
			// 
			this.tts_Sep10.Name = "tts_Sep10";
			this.tts_Sep10.Size = new System.Drawing.Size(177, 6);
			// 
			// btn_Settings_Printer_Zebra_Print
			// 
			this.btn_Settings_Printer_Zebra_Print.Name = "btn_Settings_Printer_Zebra_Print";
			this.btn_Settings_Printer_Zebra_Print.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_Zebra_Print.Text = "Print";
			this.btn_Settings_Printer_Zebra_Print.Click += new System.EventHandler(this.btn_Settings_Printer_Zebra_Print_Click);
			// 
			// btn_Settings_Printer_General
			// 
			this.btn_Settings_Printer_General.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_Settings_Printer_GeneralTitle,
            this.tts_Sep11,
            this.btn_Settings_Printer_General_Selection,
            this.tts_Sep12,
            this.btn_Settings_Printer_General_Settings,
            this.btn_Settings_Printer_General_Setup,
            this.btn_Settings_Printer_General_Preview,
            this.tts_Sep13,
            this.btn_Settings_Printer_General_Print});
			this.btn_Settings_Printer_General.Name = "btn_Settings_Printer_General";
			this.btn_Settings_Printer_General.Size = new System.Drawing.Size(180, 22);
			this.btn_Settings_Printer_General.Text = "General Printer";
			this.btn_Settings_Printer_General.DropDownOpening += new System.EventHandler(this.btn_Settings_Printer_General_DropDownOpening);
			// 
			// tst_Settings_Printer_GeneralTitle
			// 
			this.tst_Settings_Printer_GeneralTitle.BackColor = System.Drawing.Color.White;
			this.tst_Settings_Printer_GeneralTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tst_Settings_Printer_GeneralTitle.Enabled = false;
			this.tst_Settings_Printer_GeneralTitle.Name = "tst_Settings_Printer_GeneralTitle";
			this.tst_Settings_Printer_GeneralTitle.ReadOnly = true;
			this.tst_Settings_Printer_GeneralTitle.Size = new System.Drawing.Size(100, 16);
			this.tst_Settings_Printer_GeneralTitle.Text = "--- GENERAL ---";
			this.tst_Settings_Printer_GeneralTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tts_Sep11
			// 
			this.tts_Sep11.Name = "tts_Sep11";
			this.tts_Sep11.Size = new System.Drawing.Size(157, 6);
			// 
			// btn_Settings_Printer_General_Selection
			// 
			this.btn_Settings_Printer_General_Selection.Name = "btn_Settings_Printer_General_Selection";
			this.btn_Settings_Printer_General_Selection.Size = new System.Drawing.Size(160, 22);
			this.btn_Settings_Printer_General_Selection.Text = "Printer Selection";
			// 
			// tts_Sep12
			// 
			this.tts_Sep12.Name = "tts_Sep12";
			this.tts_Sep12.Size = new System.Drawing.Size(157, 6);
			// 
			// btn_Settings_Printer_General_Settings
			// 
			this.btn_Settings_Printer_General_Settings.Name = "btn_Settings_Printer_General_Settings";
			this.btn_Settings_Printer_General_Settings.Size = new System.Drawing.Size(160, 22);
			this.btn_Settings_Printer_General_Settings.Text = "Printer Settings";
			// 
			// btn_Settings_Printer_General_Setup
			// 
			this.btn_Settings_Printer_General_Setup.Name = "btn_Settings_Printer_General_Setup";
			this.btn_Settings_Printer_General_Setup.Size = new System.Drawing.Size(160, 22);
			this.btn_Settings_Printer_General_Setup.Text = "Page Setup";
			// 
			// btn_Settings_Printer_General_Preview
			// 
			this.btn_Settings_Printer_General_Preview.Name = "btn_Settings_Printer_General_Preview";
			this.btn_Settings_Printer_General_Preview.Size = new System.Drawing.Size(160, 22);
			this.btn_Settings_Printer_General_Preview.Text = "Print Preview";
			// 
			// tts_Sep13
			// 
			this.tts_Sep13.Name = "tts_Sep13";
			this.tts_Sep13.Size = new System.Drawing.Size(157, 6);
			// 
			// btn_Settings_Printer_General_Print
			// 
			this.btn_Settings_Printer_General_Print.Name = "btn_Settings_Printer_General_Print";
			this.btn_Settings_Printer_General_Print.Size = new System.Drawing.Size(160, 22);
			this.btn_Settings_Printer_General_Print.Text = "Print";
			// 
			// btn_Settings_Misc
			// 
			this.btn_Settings_Misc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_Settings_MiscTitle,
            this.btn_Settings_Misc_Font,
            this.tts_Sep06,
            this.btn_Settings_Misc_FGColor,
            this.btn_Settings_Misc_BGColor,
            this.tts_Sep05,
            this.btn_Settings_Misc_InvertColors,
            this.tts_Sep04,
            this.btn_Settings_Misc_Reset});
			this.btn_Settings_Misc.Name = "btn_Settings_Misc";
			this.btn_Settings_Misc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Settings_Misc.ShowShortcutKeys = false;
			this.btn_Settings_Misc.Size = new System.Drawing.Size(216, 22);
			this.btn_Settings_Misc.Text = "Misc Settings";
			this.btn_Settings_Misc.DropDownOpening += new System.EventHandler(this.btn_Settings_Misc_DropDownOpening);
			// 
			// tst_Settings_MiscTitle
			// 
			this.tst_Settings_MiscTitle.BackColor = System.Drawing.Color.White;
			this.tst_Settings_MiscTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tst_Settings_MiscTitle.Enabled = false;
			this.tst_Settings_MiscTitle.Name = "tst_Settings_MiscTitle";
			this.tst_Settings_MiscTitle.ReadOnly = true;
			this.tst_Settings_MiscTitle.Size = new System.Drawing.Size(100, 16);
			this.tst_Settings_MiscTitle.Text = "--- MISC ---";
			this.tst_Settings_MiscTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn_Settings_Misc_Font
			// 
			this.btn_Settings_Misc_Font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc_Font.Name = "btn_Settings_Misc_Font";
			this.btn_Settings_Misc_Font.Size = new System.Drawing.Size(188, 22);
			this.btn_Settings_Misc_Font.Text = "Font";
			this.btn_Settings_Misc_Font.ToolTipText = "The font used for the ZPL code";
			this.btn_Settings_Misc_Font.Click += new System.EventHandler(this.btn_Settings_Misc_Font_Click);
			// 
			// tts_Sep06
			// 
			this.tts_Sep06.Name = "tts_Sep06";
			this.tts_Sep06.Size = new System.Drawing.Size(185, 6);
			// 
			// btn_Settings_Misc_FGColor
			// 
			this.btn_Settings_Misc_FGColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc_FGColor.Name = "btn_Settings_Misc_FGColor";
			this.btn_Settings_Misc_FGColor.Size = new System.Drawing.Size(188, 22);
			this.btn_Settings_Misc_FGColor.Text = "Foreground Color";
			this.btn_Settings_Misc_FGColor.ToolTipText = "Foreground color of the ZPL code text area";
			this.btn_Settings_Misc_FGColor.Click += new System.EventHandler(this.btn_Settings_Misc_FGColor_Click);
			// 
			// btn_Settings_Misc_BGColor
			// 
			this.btn_Settings_Misc_BGColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc_BGColor.Name = "btn_Settings_Misc_BGColor";
			this.btn_Settings_Misc_BGColor.Size = new System.Drawing.Size(188, 22);
			this.btn_Settings_Misc_BGColor.Text = "Background Color";
			this.btn_Settings_Misc_BGColor.ToolTipText = "Background color of the ZPL code text area";
			this.btn_Settings_Misc_BGColor.Click += new System.EventHandler(this.btn_Settings_Misc_BGColor_Click);
			// 
			// tts_Sep05
			// 
			this.tts_Sep05.Name = "tts_Sep05";
			this.tts_Sep05.Size = new System.Drawing.Size(185, 6);
			// 
			// btn_Settings_Misc_InvertColors
			// 
			this.btn_Settings_Misc_InvertColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc_InvertColors.Name = "btn_Settings_Misc_InvertColors";
			this.btn_Settings_Misc_InvertColors.Size = new System.Drawing.Size(188, 22);
			this.btn_Settings_Misc_InvertColors.Text = "Invert Colors";
			this.btn_Settings_Misc_InvertColors.Click += new System.EventHandler(this.btn_Settings_Misc_InvertColors_Click);
			// 
			// tts_Sep04
			// 
			this.tts_Sep04.Name = "tts_Sep04";
			this.tts_Sep04.Size = new System.Drawing.Size(185, 6);
			// 
			// btn_Settings_Misc_Reset
			// 
			this.btn_Settings_Misc_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings_Misc_Reset.Name = "btn_Settings_Misc_Reset";
			this.btn_Settings_Misc_Reset.Size = new System.Drawing.Size(188, 22);
			this.btn_Settings_Misc_Reset.Text = "Reset Default Settings";
			this.btn_Settings_Misc_Reset.Click += new System.EventHandler(this.btn_Settings_Misc_Reset_Click);
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
			// pb_Image
			// 
			this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pb_Image.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pb_Image.Location = new System.Drawing.Point(15, 34);
			this.pb_Image.Name = "pb_Image";
			this.pb_Image.Size = new System.Drawing.Size(368, 181);
			this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Image.TabIndex = 3;
			this.pb_Image.TabStop = false;
			this.tt_ToolTip.SetToolTip(this.pb_Image, "Image (Drag to load)");
			this.pb_Image.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragDrop);
			this.pb_Image.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragEnter);
			this.pb_Image.DragOver += new System.Windows.Forms.DragEventHandler(this.pb_Image_DragOver);
			// 
			// tb_Blackness
			// 
			this.tb_Blackness.AutoSize = false;
			this.tb_Blackness.Location = new System.Drawing.Point(583, 40);
			this.tb_Blackness.Maximum = 100;
			this.tb_Blackness.Minimum = 1;
			this.tb_Blackness.Name = "tb_Blackness";
			this.tb_Blackness.Size = new System.Drawing.Size(104, 17);
			this.tb_Blackness.TabIndex = 24;
			this.tb_Blackness.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tt_ToolTip.SetToolTip(this.tb_Blackness, "Set color tolerance level \r\n( Default is 59% )");
			this.tb_Blackness.Value = 59;
			this.tb_Blackness.ValueChanged += new System.EventHandler(this.tb_Blackness_ValueChanged);
			// 
			// btn_MoreMenu
			// 
			this.btn_MoreMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_MoreMenu.BackgroundImage = global::img2zpl.Properties.Resources.menu_2;
			this.btn_MoreMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_MoreMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_MoreMenu.FlatAppearance.BorderSize = 0;
			this.btn_MoreMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_MoreMenu.Location = new System.Drawing.Point(749, 4);
			this.btn_MoreMenu.Name = "btn_MoreMenu";
			this.btn_MoreMenu.Size = new System.Drawing.Size(24, 24);
			this.btn_MoreMenu.TabIndex = 27;
			this.tt_ToolTip.SetToolTip(this.btn_MoreMenu, "Show more menu items");
			this.btn_MoreMenu.UseVisualStyleBackColor = true;
			this.btn_MoreMenu.Click += new System.EventHandler(this.btn_MoreMenu_Click);
			// 
			// btn_SendToPrinter
			// 
			this.btn_SendToPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SendToPrinter.BackgroundImage = global::img2zpl.Properties.Resources.labelprint;
			this.btn_SendToPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_SendToPrinter.Location = new System.Drawing.Point(724, 33);
			this.btn_SendToPrinter.Name = "btn_SendToPrinter";
			this.btn_SendToPrinter.Size = new System.Drawing.Size(47, 29);
			this.btn_SendToPrinter.TabIndex = 28;
			this.tt_ToolTip.SetToolTip(this.btn_SendToPrinter, "Send ZPL code to printer");
			this.btn_SendToPrinter.UseVisualStyleBackColor = true;
			// 
			// cb_Help
			// 
			this.cb_Help.AutoSize = true;
			this.cb_Help.Location = new System.Drawing.Point(439, 40);
			this.cb_Help.Name = "cb_Help";
			this.cb_Help.Size = new System.Drawing.Size(48, 17);
			this.cb_Help.TabIndex = 23;
			this.cb_Help.Text = "Help";
			this.cb_Help.UseVisualStyleBackColor = true;
			this.cb_Help.CheckedChanged += new System.EventHandler(this.cb_Help_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(525, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Black level";
			// 
			// lbl_BlackLevelPercent
			// 
			this.lbl_BlackLevelPercent.AutoSize = true;
			this.lbl_BlackLevelPercent.Location = new System.Drawing.Point(691, 41);
			this.lbl_BlackLevelPercent.Name = "lbl_BlackLevelPercent";
			this.lbl_BlackLevelPercent.Size = new System.Drawing.Size(27, 13);
			this.lbl_BlackLevelPercent.TabIndex = 26;
			this.lbl_BlackLevelPercent.Text = "59%";
			// 
			// prnt_PrintPreviewDialog
			// 
			this.prnt_PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prnt_PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prnt_PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this.prnt_PrintPreviewDialog.Enabled = true;
			this.prnt_PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("prnt_PrintPreviewDialog.Icon")));
			this.prnt_PrintPreviewDialog.Name = "prnt_PrintPreviewDialog";
			this.prnt_PrintPreviewDialog.Visible = false;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 251);
			this.Controls.Add(this.rtb_Zebra);
			this.Controls.Add(this.btn_SendToPrinter);
			this.Controls.Add(this.btn_MoreMenu);
			this.Controls.Add(this.lbl_BlackLevelPercent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Blackness);
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
			this.p_Resize.ResumeLayout(false);
			this.p_Resize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Resize_Width)).EndInit();
			this.cm_Settings.ResumeLayout(false);
			this.cm_Settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_Blackness)).EndInit();
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
		private System.Windows.Forms.ToolStripSeparator tts_Sep01;
		private System.Windows.Forms.ToolStripTextBox tst_SettingsTitle;
		private System.Windows.Forms.ToolTip tt_ToolTip;
		private System.Windows.Forms.ToolStripSeparator tts_Sep02;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_LoadLastImage;
		private System.Windows.Forms.ToolStripSeparator tts_Sep03;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_Font;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_FGColor;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_BGColor;
		private System.Windows.Forms.CheckBox cb_Help;
		private System.Windows.Forms.TrackBar tb_Blackness;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_BlackLevelPercent;
		private System.Windows.Forms.Button btn_MoreMenu;
		private System.Windows.Forms.Button btn_SendToPrinter;
		private System.Windows.Forms.ToolStripSeparator tts_Sep04;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_Reset;
		private System.Windows.Forms.ToolStripSeparator tts_Sep06;
		private System.Windows.Forms.ToolStripSeparator tts_Sep05;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Misc_InvertColors;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General;
		private System.Windows.Forms.ToolStripTextBox tst_Settings_PrinterTitle;
		private System.Windows.Forms.ToolStripTextBox tst_Settings_Printer_ZebraTitle;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra_Setup;
		private System.Windows.Forms.ToolStripTextBox tst_Settings_Printer_GeneralTitle;
		private System.Windows.Forms.ToolStripTextBox tst_Settings_MiscTitle;
		private System.Windows.Forms.ToolStripSeparator tts_Sep07;
		private System.Windows.Forms.ToolStripSeparator tts_Sep08;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra_Selection;
		private System.Windows.Forms.ToolStripSeparator tts_Sep09;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra_Preview;
		private System.Windows.Forms.ToolStripSeparator tts_Sep10;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_Zebra_Print;
		private System.Windows.Forms.ToolStripSeparator tts_Sep11;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General_Selection;
		private System.Windows.Forms.ToolStripSeparator tts_Sep12;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General_Setup;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General_Preview;
		private System.Windows.Forms.ToolStripSeparator tts_Sep13;
		private System.Windows.Forms.ToolStripMenuItem btn_Settings_Printer_General_Print;
		private System.Windows.Forms.PageSetupDialog prnt_PageSetupDialog;
		private System.Drawing.Printing.PrintDocument prnt_PrintDocument;
		private System.Windows.Forms.PrintPreviewDialog prnt_PrintPreviewDialog;
	}
}

