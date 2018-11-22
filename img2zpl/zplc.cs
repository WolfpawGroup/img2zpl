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
		private static Dictionary<int, string> mapCode = new Dictionary<int, string>();

		public zplc()
		{
			mapCode.Add(1	, "G");
			mapCode.Add(2	, "H");
			mapCode.Add(3	, "I");
			mapCode.Add(4	, "J");
			mapCode.Add(5	, "K");
			mapCode.Add(6	, "L");
			mapCode.Add(7	, "M");
			mapCode.Add(8	, "N");
			mapCode.Add(9	, "O");
			mapCode.Add(10	, "P");
			mapCode.Add(11	, "Q");
			mapCode.Add(12	, "R");
			mapCode.Add(13	, "S");
			mapCode.Add(14	, "T");
			mapCode.Add(15	, "U");
			mapCode.Add(16	, "V");
			mapCode.Add(17	, "W");
			mapCode.Add(18	, "X");
			mapCode.Add(19	, "Y");
			mapCode.Add(20	, "g");
			mapCode.Add(40	, "h");
			mapCode.Add(60	, "i");
			mapCode.Add(80	, "j");
			mapCode.Add(100	, "k");
			mapCode.Add(120	, "l");
			mapCode.Add(140	, "m");
			mapCode.Add(160	, "n");
			mapCode.Add(180	, "o");
			mapCode.Add(200	, "p");
			mapCode.Add(220	, "q");
			mapCode.Add(240	, "r");
			mapCode.Add(260	, "s");
			mapCode.Add(280	, "t");
			mapCode.Add(300	, "u");
			mapCode.Add(320	, "v");
			mapCode.Add(340	, "w");
			mapCode.Add(360	, "x");
			mapCode.Add(380	, "y");
			mapCode.Add(400	, "z");

			mapCode.Reverse();
		}

		public string convertFromImage(Bitmap image, bool addHeaderFooter)
		{
			string hexAscii = createBody(image);
			if (compressHex)
			{
				hexAscii = encodeHexAscii(hexAscii);
			}

			hexAscii = fixZpl(hexAscii);

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
						sbLinea.Append(mapCode[multi20]);
						if (resto20 != 0)
						{
							sbLinea.Append(mapCode[resto20]).Append(aux);
						}
						else
						{
							sbLinea.Append(aux);
						}
					}
					else
					{
						sbLinea.Append(mapCode[counter]).Append(aux);
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
						sbLinea.Append(mapCode[multi20]);
						if (resto20 != 0)
						{
							sbLinea.Append(mapCode[resto20]).Append(aux);
						}
						else
						{
							sbLinea.Append(aux);
						}
					}
					else
					{
						sbLinea.Append(mapCode[counter]).Append(aux);
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

		public string calculateCharacterNum(int i)
		{
			string ret = "";

			while(i > 0)
			{
				foreach(KeyValuePair<int, string> kvp in mapCode.Reverse())
				{
					if(i >= kvp.Key)
					{ i -= kvp.Key; ret += kvp.Value; break; }
				}
			}

			return ret;
		}

		public string fixZpl(string zpl)
		{
			string ret = "";
			char chr = '\0';
			int chrcount = 0;

			foreach(char c in zpl)
			{
				if(c != chr)
				{
					if (chr != '\0')
					{
						if (chrcount > 1)
						{
							ret += calculateCharacterNum(chrcount) + chr.ToString();
						}
						else
						{
							ret += chr.ToString();
						}
					}

					chr = c;
					chrcount = 1;
				}
				else
				{
					chrcount++;
				}
			}

			ret = ret.Replace("\n", "");

			return ret;
		}

	}
}
