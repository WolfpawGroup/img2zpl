using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace img2zpl
{
	class zplc
	{

		private int blackLimit = 380;
		private int total;
		private int widthBytes;
		private bool compressHex = false;
		private static Dictionary<string, int> mapCode = new Dictionary<string, int>();

		public zplc()
		{
			mapCode.Add("G", 1);
			mapCode.Add("H", 2);
			mapCode.Add("I", 3);
			mapCode.Add("J", 4);
			mapCode.Add("K", 5);
			mapCode.Add("L", 6);
			mapCode.Add("M", 7);
			mapCode.Add("N", 8);
			mapCode.Add("O", 9);
			mapCode.Add("P", 10);
			mapCode.Add("Q", 11);
			mapCode.Add("R", 12);
			mapCode.Add("S", 13);
			mapCode.Add("T", 14);
			mapCode.Add("U", 15);
			mapCode.Add("V", 16);
			mapCode.Add("W", 17);
			mapCode.Add("X", 18);
			mapCode.Add("Y", 19);
			mapCode.Add("g", 20);
			mapCode.Add("h", 40);
			mapCode.Add("i", 60);
			mapCode.Add("j", 80);
			mapCode.Add("k", 100);
			mapCode.Add("l", 120);
			mapCode.Add("m", 140);
			mapCode.Add("n", 160);
			mapCode.Add("o", 180);
			mapCode.Add("p", 200);
			mapCode.Add("q", 220);
			mapCode.Add("r", 240);
			mapCode.Add("s", 260);
			mapCode.Add("t", 280);
			mapCode.Add("u", 300);
			mapCode.Add("v", 320);
			mapCode.Add("w", 340);
			mapCode.Add("x", 360);
			mapCode.Add("y", 380);
			mapCode.Add("z", 400);
		}

		public string convertFromImage(Bitmap image, bool addHeaderFooter)
		{
			string hexAscii = createBody(image);
			if (compressHex)
			{
				hexAscii = encodeHexAscii(hexAscii);
			}

			string zplCode = "^GFA," + total + "," + total + "," + widthBytes + ", " + hexAscii;

			if (addHeaderFooter)
			{
				string header = "^XA " + "^FO0,0^GFA," + total + "," + total + "," + widthBytes + ", ";
				string footer = "^FS" + "^XZ";
				zplCode = header + zplCode + footer;
			}
			return zplCode;
		}

		private string createBody(Bitmap bitmapImage)
		{
			StringBuilder sb = new StringBuilder();
			int height = bitmapImage.Height;
			int width = bitmapImage.Width;
			int red, green, blue, index = 0;
			Color rgb = Color.White;
			char[] auxBinaryChar = { '0', '0', '0', '0', '0', '0', '0', '0' };
			widthBytes = width / 8;
			if (width % 8 > 0)
			{
				widthBytes = (((int)(width / 8)) + 1);
			}
			else
			{
				widthBytes = width / 8;
			}
			this.total = widthBytes * height;
			for (int h = 0; h < height; h++)
			{
				for (int w = 0; w < width; w++)
				{
					rgb = bitmapImage.GetPixel(w, h);
					//red = (rgb >> 16) & 0x000000FF;
					//green = (rgb >> 8) & 0x000000FF;
					//blue = (rgb) & 0x000000FF;
					red = rgb.R;
					green = rgb.G;
					blue = rgb.B;

					char auxChar = '1';
					int totalColor = red + green + blue;
					if (totalColor > blackLimit)
					{
						auxChar = '0';
					}
					auxBinaryChar[index] = auxChar;
					index++;
					if (index == 8 || w == (width - 1))
					{
						sb.Append(fourByteBinary(new string(auxBinaryChar)));
						auxBinaryChar = new char[] { '0', '0', '0', '0', '0', '0', '0', '0' };
						index = 0;
					}
				}
				sb.Append("\n");
			}
			return sb.ToString();
		}

		private string fourByteBinary(string binaryStr)
		{
			int _dec = Convert.ToInt32(binaryStr, 2);
			if (_dec > 15)
			{
				return _dec.ToString("X").ToUpper();
			}
			else
			{
				return "0" + _dec.ToString("X").ToUpper();
			}
		}

		private string encodeHexAscii(string code)
		{
			int maxlinea = widthBytes * 2;
			StringBuilder sbCode = new StringBuilder();
			StringBuilder sbLinea = new StringBuilder();
			string previousLine = null;
			int counter = 1;
			char aux = code[0];
			bool firstChar = false;
			for (int i = 1; i < code.Length; i++)
			{
				if (firstChar)
				{
					aux = code[i];
					firstChar = false;
					continue;
				}
				if (code[i] == '\n')
				{
					if (counter >= maxlinea && aux == '0')
					{
						sbLinea.Append(",");
					}
					else if (counter >= maxlinea && aux == 'F')
					{
						sbLinea.Append("!");
					}
					else if (counter > 20)
					{
						int multi20 = (counter / 20) * 20;
						int resto20 = (counter % 20);
						sbLinea.Append(mapCode.Where(x => x.Value == multi20));
						if (resto20 != 0)
						{
							sbLinea.Append(mapCode.Where(x => x.Value == resto20)).Append(aux);
						}
						else
						{
							sbLinea.Append(aux);
						}
					}
					else
					{
						sbLinea.Append(mapCode.Where(x => x.Value == counter)).Append(aux);
					}
					counter = 1;
					firstChar = true;
					if (sbLinea.ToString() == previousLine)
					{
						sbCode.Append(":");
					}
					else
					{
						sbCode.Append(sbLinea.ToString());
					}
					previousLine = sbLinea.ToString();
					sbLinea.Length = 0;
					continue;
				}
				if (aux == code[i])
				{
					counter++;
				}
				else
				{
					if (counter > 20)
					{
						int multi20 = (counter / 20) * 20;
						int resto20 = (counter % 20);
						sbLinea.Append(mapCode.Where(x => x.Value == multi20));
						if (resto20 != 0)
						{
							sbLinea.Append(mapCode.Where(x => x.Value == resto20)).Append(aux);
						}
						else
						{
							sbLinea.Append(aux);
						}
					}
					else
					{
						sbLinea.Append(mapCode.Where(x => x.Value == counter)).Append(aux);
					}
					counter = 1;
					aux = code[i];
				}
			}
			return sbCode.ToString();
		}

		public void setCompressHex(bool compressHex)
		{
			this.compressHex = compressHex;
		}

		public void setBlacknessLimitPercentage(int percentage)
		{
			blackLimit = (percentage * 768 / 100);
		}

		public string fixZpl(string zpl)
		{

		}

	}
}
