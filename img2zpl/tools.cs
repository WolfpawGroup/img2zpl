using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2zpl
{
	public static class tools
	{
		public static double getAspectWidth(int height, int width)
		{
			return (((100 * 1d) / (height * 1d)) * (width * 1d));
		}

		public static double getAspectHeight(int height, int width)
		{
			return (((100 * 1d) / (width * 1d)) * (height * 1d));
		}

		public static int getProperWidth(int original_height, int original_width, int new_height)
		{
			double aspect = getAspectWidth(original_height, original_width);
			return (int)Math.Floor(aspect * new_height);
		}

		public static int getProperHeight(int original_height, int original_width, int new_width)
		{
			double aspect = getAspectHeight(original_height, original_width);
			return (int)Math.Floor(aspect * new_width);
		}
	}
}
