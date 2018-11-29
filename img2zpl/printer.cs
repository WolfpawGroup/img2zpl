using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Management;

namespace img2zpl
{
	class printer
	{
		public PrinterSettings.StringCollection getPrinterList()
		{
			return PrinterSettings.InstalledPrinters;
		}

		public string getPrinterInfo(string printer)
		{
			ManagementObjectSearcher printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
			ManagementObject prntr = null;
			foreach (ManagementObject p in printerQuery.Get())
			{
				if(p.GetPropertyValue("Name").ToString().ToLower() == printer.ToLower())
				{
					prntr = p;
				}
			}

			if (prntr != null)
			{
				var name = prntr.GetPropertyValue("Name");
				var status = prntr.GetPropertyValue("Status");
				var isDefault = prntr.GetPropertyValue("Default");
				var isNetworkPrinter = prntr.GetPropertyValue("Network");

				return string.Format("{0} (Status: {1}, Default: {2}, Network: {3}", name, status, isDefault, isNetworkPrinter);
			}
			else
			{
				return "";
			}
		}
	}
}
