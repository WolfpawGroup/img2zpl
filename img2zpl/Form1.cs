using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2zpl
{
	public partial class Form1 : Form
	{
		zplc z = new zplc();
		public Bitmap bmp = null;
		public string fileName = "";
		public Size originalSize = default(Size);
		public Size resizedSize = default(Size);
		public bool resize = false;
		public bool headerfooter = false;
		public bool compress = false;
		public bool loaded = false;
		public bool menuOpened = false;
		public bool invertColors = false;
		public List<string> printers = new List<string>();
		public string defaultZebraPrinter = "";
		public string defaultGeneralPrinter = "";


		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadSettings();
			loaded = true;
			settth();
		}

		public void loadSettings()
		{
			cb_Resize.Checked = Properties.Settings.Default.s_Resize;
			cb_LockAspectRatio.Checked = Properties.Settings.Default.s_LockRatio;
			btn_Settings_AddHeaderFooter.Checked = Properties.Settings.Default.s_HeaderFooter;
			btn_Settings_CompressHex.Checked = Properties.Settings.Default.s_CompressHex;
			btn_Settings_GenerateAsPerlCode.Checked = Properties.Settings.Default.s_GeneratePerlCode;
			btn_Settings_SeparateToLines.Checked = Properties.Settings.Default.s_NewLinePerRow;
			num_Resize_Height.Value = (int)Properties.Settings.Default.s_ResizeHeight;
			num_Resize_Width.Value = (int)Properties.Settings.Default.s_ResizeWidth;
			if(Properties.Settings.Default.s_Top + Properties.Settings.Default.s_Left == 0)
			{
				this.StartPosition = FormStartPosition.CenterScreen;
			}
			else
			{
				this.StartPosition = FormStartPosition.Manual;
				Left = Properties.Settings.Default.s_Left;
				Top = Properties.Settings.Default.s_Top;
			}

			tb_Blackness.Value = Properties.Settings.Default.s_BlackLevel;

			if(Properties.Settings.Default.s_Width + Properties.Settings.Default.s_Height == 0)
			{
				Size = MinimumSize;
			}
			else
			{
				Size = new Size(Properties.Settings.Default.s_Width, Properties.Settings.Default.s_Height);
			}

			defaultGeneralPrinter = Properties.Settings.Default.s_DefaultGeneralPrinter;
			defaultZebraPrinter = Properties.Settings.Default.s_DefaultZebraPrinter;

			settingsApply();
		}

		private void pb_Image_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		private void pb_Image_DragDrop(object sender, DragEventArgs e)
		{
			if(e.Effect != DragDropEffects.None)
			{
				tb_ImagePath.Text = (e.Data.GetData(DataFormats.FileDrop) as string[] )[0];
			}
		}

		private void pb_Image_DragOver(object sender, DragEventArgs e)
		{

		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void Form1_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			int left = this.Left + pb_Image.Left;
			int top = this.Top + pb_Image.Top;

			if( (	e.X > left	&&	e.X < left	+ pb_Image.Width	) && 
				(	e.Y > top	&&	e.Y < top	+ pb_Image.Height	) )
			{
				if (e.Effect != DragDropEffects.None)
				{
					fileName = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
					loadImg();
				}
			}
		}

		public void manageSize()
		{
			originalSize = bmp.Size;
			resizedSize = new Size((int)num_Resize_Width.Value, (int)num_Resize_Height.Value);
			if (num_Resize_Height.Value + num_Resize_Width.Value == 0 || cb_Resize.Checked == false)
			{
				num_Resize_Width.Value = (int)originalSize.Width;
				num_Resize_Height.Value = (int)originalSize.Height;
				resizedSize = originalSize;
			}
		}

		public void loadImg()
		{
			tb_ImagePath.Text = fileName;
			bmp = (Bitmap)(new Bitmap(tb_ImagePath.Text).Clone());
			saveImageToSettings((Image)bmp.Clone());
			pb_Image.Image = bmp;
			manageSize();

		}

		private void btn_LoadImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image Files|*.jpg;*.png;*.bmp;*.jpeg;*.gif|All Files|*.*";
			ofd.Title = "Open Image File to Convert";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				fileName = ofd.FileName;
				loadImg();
			}
		}

		public void saveImageToSettings(Image bmp)
		{
			String bdat = "";

			try
			{
				using (Image image = bmp)
				{
					using (MemoryStream m = new MemoryStream())
					{
						image.Save(m, image.RawFormat);
						byte[] imageBytes = m.ToArray();
						bdat = Convert.ToBase64String(imageBytes);
					}
				}
			}
			catch
			{

			}

			Properties.Settings.Default.s_LastImage = bdat;
			Properties.Settings.Default.Save();
		}

		private void btn_Image_Copy_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(bmp);
		}

		private void btn_Image_Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Image Files|*.jpg;*.png;*.bmp;*.jpeg;*.gif|All Files|*.*";
			sfd.DefaultExt = ".jpg";
			sfd.Title = "Save Image";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				bmp.Save(sfd.FileName);
			}
		}

		private void btn_ConvertToZebra_Click(object sender, EventArgs e)
		{
			convert2z();
		}

		public void convert2z()
		{
			if (bmp != null)
			{
				Bitmap bbmp = bmp;
				if (cb_Resize.Checked && (num_Resize_Height.Value > 0 && num_Resize_Width.Value > 0)) { bbmp = new Bitmap(bmp, new Size((int)num_Resize_Width.Value, (int)num_Resize_Height.Value)); }
				rtb_Zebra.Text = z.convertFromImage(bbmp, tb_Blackness.Value, btn_Settings_AddHeaderFooter.Checked, btn_Settings_CompressHex.Checked, btn_Settings_SeparateToLines.Checked, btn_Settings_GenerateAsPerlCode.Checked);
			}
		}

		private void btn_preview_Click(object sender, EventArgs e)
		{
			manageSize();
			if (rtb_Zebra.Text != "")
			{
				int dpi1 = 96;
				int dpi2 = 96;

				using (Graphics gr = this.CreateGraphics())
				{
					dpi1 = (int)gr.DpiX;
					dpi2 = (int)gr.DpiY;
				}

				int w = resizedSize.Width / dpi1;
				int h = resizedSize.Height / dpi2;
				string url = "http://api.labelary.com/v1/printers/8dpmm/labels/{width}x{height}/{index}/"; // /zpl
				byte[] zpl = Encoding.UTF8.GetBytes(rtb_Zebra.Text);
				string url1 = url.Replace("{width}", w + "").Replace("{height}", h + "").Replace("{index}", "0");
				string url2 = url.Replace("{width}", 4 + "").Replace("{height}", 6 + "").Replace("{index}", "0");

				Bitmap b1 = null;
				Bitmap b2 = null;

				b1 = getbmfromstream(url1, zpl);
				b2 = getbmfromstream(url2, zpl);

				f_Preview p = new f_Preview();
				p.Show();
				p.loadImages(b1, b2);
			}
		}

		public Bitmap getbmfromstream(string url,byte[] zpl)
		{
			HttpWebRequest req = WebRequest.CreateHttp(url);
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded";
			req.ContentLength = zpl.Length;
			req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:63.0) Gecko/20100101 Firefox/63.0";

			var requestStream = req.GetRequestStream();
			requestStream.Write(zpl, 0, zpl.Length);
			requestStream.Close();

			HttpWebResponse res = (HttpWebResponse)req.GetResponse();
			using (StreamReader s = new StreamReader(res.GetResponseStream()))
			{
				using (MemoryStream m = new MemoryStream())
				{
					var buffer = new byte[4096];
					var bytesRead = default(int);
					while ((bytesRead = s.BaseStream.Read(buffer, 0, buffer.Length)) > 0)
					{
						m.Write(buffer, 0, bytesRead);
					}

					return new Bitmap(m);
				}
			}
		}

		private void btn_OriginalSize_Click(object sender, EventArgs e)
		{
			num_Resize_Height.Value = originalSize.Height;
			num_Resize_Width.Value = originalSize.Width;
			loadImg();
		}

		private void btn_Settings_MouseClick(object sender, MouseEventArgs e)
		{
			if (cm_Settings.isopen)
			{
				cm_Settings.Close();
			}
			else
			{
				cm_Settings.Show(this, new Point(btn_Settings.Location.X, btn_Settings.Location.Y + btn_Settings.Height));
			}
		}

		public void closecm()
		{
			if (cm_Settings.isopen) { cm_Settings.Close(); }
		}

		private void rtb_Zebra_Click(object sender, EventArgs e)
		{
			closecm();
		}

		public void checkResize()
		{
			p_Resize.Enabled = cb_Resize.Checked;
		}

		private void cb_Resize_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_Resize = cb_Resize.Checked;
			Properties.Settings.Default.Save();

			checkResize();
		}

		private void cm_Settings_MouseLeave(object sender, EventArgs e)
		{
			if (!btn_Settings_Misc.DropDown.Visible && !btn_Settings_Printer.Visible)
			{
				cm_Settings.Close();
			}
		}

		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			if(loaded)
			setSizeAndPos();
		}

		public void setSizeAndPos()
		{
			Properties.Settings.Default.s_Width = Width;
			Properties.Settings.Default.s_Height = Height;
			Properties.Settings.Default.s_Left = Left;
			Properties.Settings.Default.s_Top = Top;
			save();
		}

		public void save()
		{
			Properties.Settings.Default.Save();
		}

		private void btn_Settings_AddHeaderFooter_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_HeaderFooter = btn_Settings_AddHeaderFooter.Checked;
			save();
		}

		private void btn_Settings_CompressHex_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_CompressHex = btn_Settings_CompressHex.Checked;
			save();
		}

		private void btn_Settings_SeparateToLines_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_NewLinePerRow = btn_Settings_SeparateToLines.Checked;
			save();
		}

		private void btn_Settings_GenerateAsPerlCode_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_GeneratePerlCode = btn_Settings_GenerateAsPerlCode.Checked;
			save();
		}

		private void btn_Settings_LoadLastImage_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.s_LastImage != "")
			{
				bmp = (Bitmap)Image.FromStream(new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.s_LastImage)));

				originalSize = bmp.Size;
				resizedSize = new Size((int)num_Resize_Width.Value, (int)num_Resize_Height.Value);
				if (num_Resize_Height.Value + num_Resize_Width.Value == 0 || cb_Resize.Checked == false)
				{
					num_Resize_Width.Value = (int)originalSize.Width;
					num_Resize_Height.Value = (int)originalSize.Height;
					resizedSize = originalSize;
				}

				pb_Image.Image = (Bitmap)bmp.Clone();


			}
		}

		public void settingsApply()
		{
			rtb_Zebra.Font = Properties.Settings.Default.s_Font;
			rtb_Zebra.ForeColor = Properties.Settings.Default.s_FGColor;
			rtb_Zebra.BackColor = Properties.Settings.Default.s_BGColor;
		}

		private void btn_Settings_Misc_Font_Click(object sender, EventArgs e)
		{
			closecm();
			FontDialog fd = new FontDialog();
			fd.AllowSimulations = true;
			fd.AllowVectorFonts = true;
			fd.AllowScriptChange = true;
			fd.AllowVerticalFonts = true;
			fd.ShowEffects = true;
			fd.ShowHelp = true;
			fd.ShowApply = false;
			fd.Color = Properties.Settings.Default.s_FGColor;
			fd.ShowColor = true;
			fd.MinSize = 1;
			if (Properties.Settings.Default.s_Font != default(Font))
			{
				fd.Font = Properties.Settings.Default.s_Font;
			}
			if(fd.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.s_Font = fd.Font;
			}
			save();
			settingsApply();
		}

		private void btn_Settings_Misc_FGColor_Click(object sender, EventArgs e)
		{
			closecm();
			ColorDialog cd = new ColorDialog();
			cd.AnyColor = true;
			cd.AllowFullOpen = true;
			cd.FullOpen = true;
			cd.ShowHelp = true;
			cd.Color = Properties.Settings.Default.s_FGColor;
			if(cd.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.s_FGColor = cd.Color;
			}
			save();
			settingsApply();
		}

		private void btn_Settings_Misc_BGColor_Click(object sender, EventArgs e)
		{
			closecm();
			ColorDialog cd = new ColorDialog();
			cd.AnyColor = true;
			cd.AllowFullOpen = true;
			cd.FullOpen = true;
			cd.ShowHelp = true;
			cd.Color = Properties.Settings.Default.s_BGColor;
			if (cd.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.s_BGColor = cd.Color;
			}
			save();
			settingsApply();
		}

		private void cb_Help_CheckedChanged(object sender, EventArgs e)
		{
			settth();
		}

		public void settth()
		{
			tt_ToolTip.Active = cb_Help.Checked;
		}

		private void cm_Settings_Opening(object sender, CancelEventArgs e)
		{
			cm_Settings.ShowItemToolTips = tt_ToolTip.Active;
		}

		private void btn_Settings_Misc_DropDownOpening(object sender, EventArgs e)
		{
			var fnt = Properties.Settings.Default.s_Font;
			Color cb = Properties.Settings.Default.s_BGColor;
			Color cf = Properties.Settings.Default.s_FGColor;
			btn_Settings_Misc_Font.ToolTipText = "The font used for the ZPL code \n" + $"({fnt.Name} | {fnt.Size} | {((fnt.Italic ? "Italic, " : "") + (fnt.Bold ? "Bold, " : "") + (fnt.Strikeout ? "Strikeout, " : "") + (fnt.Underline ? "Underline, " : "")).Trim(',', ' ')})".Replace("| )",")");
			btn_Settings_Misc_BGColor.ToolTipText = "Background color of the ZPL code text area \n" + $"( {((cb.IsSystemColor || cb.IsNamedColor) ? cb.Name : "#" + cb.R.ToString("X2") + cb.G.ToString("X2") + cb.B.ToString("X2"))} )";
			btn_Settings_Misc_FGColor.ToolTipText = "Foreground color of the ZPL code text area \n" + $"( {((cf.IsSystemColor || cf.IsNamedColor) ? cf.Name : "#" + cf.R.ToString("X2") + cf.G.ToString("X2") + cf.B.ToString("X2"))} )";
		}

		private void btn_Zebra_Copy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtb_Zebra.Text);
		}

		private void btn_Zebra_Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Text Files|*.txt;*.rtf;*.html;*.xml;*.pl|All Files|*.*";
			sfd.DefaultExt = ".txt";
			sfd.Title = "Save ZPL Code";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				if (sfd.FileName.ToLower().EndsWith(".rtf"))
				{
					File.WriteAllText(sfd.FileName, rtb_Zebra.Rtf);
				}
				else if (sfd.FileName.ToLower().EndsWith(".pl") && !btn_Settings_GenerateAsPerlCode.Checked)
				{
					DialogResult d = MessageBox.Show("You have selected the .pl extension, but your code is not formatted as a perl script.\r\nWould you like to regenerate the code in Perl format?", "That's not right", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (d == DialogResult.Yes)
					{
						btn_Settings_GenerateAsPerlCode.Checked = true;
						convert2z();
						btn_Settings_GenerateAsPerlCode.Checked = false;
					}
					else if (d == DialogResult.Cancel)
					{
						return;
					}
					File.WriteAllText(sfd.FileName, rtb_Zebra.Text);
				}
				else
				{
					File.WriteAllText(sfd.FileName, rtb_Zebra.Text);
				}
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_ConvertToImage_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action is not yet implemented.\r\nPlease check later!","Not implemented!");
		}

		private void btn_MoreMenu_Click(object sender, EventArgs e)
		{
			menuOpened = !menuOpened;
			handleMenu();
		}

		public void handleMenu()
		{
			if (menuOpened)
			{
				rtb_Zebra.Top += 30;
				rtb_Zebra.Height -= 30;
			}
			else
			{
				rtb_Zebra.Top -= 30;
				rtb_Zebra.Height += 30;
			}
		}

		private void tb_Blackness_ValueChanged(object sender, EventArgs e)
		{
			lbl_BlackLevelPercent.Text = tb_Blackness.Value + "%";
			Properties.Settings.Default.s_BlackLevel = tb_Blackness.Value;
			save();
		}

		private void btn_Settings_Misc_Reset_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_Font = Properties.Settings.Default.s_Font_Default;
			Properties.Settings.Default.s_FGColor = Properties.Settings.Default.s_FGColor_Default;
			Properties.Settings.Default.s_BGColor = Properties.Settings.Default.s_BGColor_Default;
			save();
			loadSettings();
			settingsApply();
			closecm();
		}

		private void btn_Settings_Misc_InvertColors_Click(object sender, EventArgs e)
		{
			Color c = Properties.Settings.Default.s_BGColor;
			Properties.Settings.Default.s_BGColor = Properties.Settings.Default.s_FGColor;
			Properties.Settings.Default.s_FGColor = c;
			save();
			settingsApply();
			closecm();
		}

		public void printerAdd(string type, string printer)
		{
			ToolStripMenuItem p = new ToolStripMenuItem();
			p.Text = printer;
			
			if(type == "z")
			{
				p.Click += P_Click;
				btn_Settings_Printer_Zebra_Selection.DropDown.Items.Add(p);
				if(defaultZebraPrinter.ToLower() == printer.ToLower())
				{
					p.Checked = true;
				}
			}
			else
			{
				p.Click += P_Click1;
				btn_Settings_Printer_General_Selection.DropDown.Items.Add(p);
				if (defaultGeneralPrinter.ToLower() == printer.ToLower())
				{
					p.Checked = true;
				}
			}
		}

		private void P_Click1(object sender, EventArgs e)
		{
			defaultGeneralPrinter = (sender as ToolStripMenuItem).Text;
			Properties.Settings.Default.s_DefaultGeneralPrinter = defaultGeneralPrinter;
			save();
		}

		private void P_Click(object sender, EventArgs e)
		{
			defaultZebraPrinter = (sender as ToolStripMenuItem).Text;
			Properties.Settings.Default.s_DefaultZebraPrinter = defaultZebraPrinter;
			save();
		}

		private void btn_Settings_Printer_Zebra_DropDownOpening(object sender, EventArgs e)
		{
			btn_Settings_Printer_Zebra_Selection.DropDown.Items.Clear();
			printers = new printer().getPrinterList().Cast<string>().ToList();
			foreach(string s in printers)
			{
				printerAdd("z", s);
			}
		}

		private void btn_Settings_Printer_General_DropDownOpening(object sender, EventArgs e)
		{
			btn_Settings_Printer_General_Selection.DropDown.Items.Clear();
			printers = new printer().getPrinterList().Cast<string>().ToList();
			foreach (string s in printers)
			{
				printerAdd("g", s);
			}
		}
	}
}
