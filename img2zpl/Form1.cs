using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2zpl
{
	public partial class Form1 : Form
	{
		public Bitmap bmp = null;
		public string fileName = "";

		public Form1()
		{
			InitializeComponent();
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

		public void loadImg()
		{
			tb_ImagePath.Text = fileName;
			bmp = (Bitmap)(new Bitmap(tb_ImagePath.Text).Clone());
			pb_Image.Image = bmp;
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
			zplc z = new zplc();
			rtb_Zebra.Text = z.convertFromImage(bmp, true);
		}
	}
}
