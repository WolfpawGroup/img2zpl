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
	public partial class f_Preview : Form
	{
		public f_Preview()
		{
			InitializeComponent();
		}

		public void loadImages(Bitmap bmp1 = null, Bitmap bmp2 = null)
		{
			using (Graphics g = Graphics.FromImage(bmp1))
			{
				g.DrawString("Original Size image preview", new Font(this.Font.FontFamily,22,FontStyle.Regular), Brushes.YellowGreen, new Point(20, 20));
			}
			using (Graphics g = Graphics.FromImage(bmp2))
			{
				g.DrawString("10 * 15 label Size image preview", new Font(this.Font.FontFamily, 22, FontStyle.Regular), Brushes.YellowGreen, new Point(20, 20));
			}

			if (bmp1 != null) { pb_Image1.Image = bmp1; }
			if(bmp2 != null) { pb_Image2.Image = bmp2; }
		}
	}
}
