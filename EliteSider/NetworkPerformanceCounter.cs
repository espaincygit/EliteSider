using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Management;

namespace EliteSider
{
	class WiFiPerformanceCounter : CommonPerformanceCounter
	{
		private string netName = string.Empty;
		//private long speed = 0;

        ManagementObjectSearcher network;
		//ManagementObject network;

		public WiFiPerformanceCounter()
		{
			// Look for a "real" network interface, and preferably
			// a WiFi, as it uses the most power.
			/*NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface ni in interfaces)
			{
				if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
					ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.AsymmetricDsl)
				{
					netName = ni.Description.Replace("(", "[").Replace(")", "]");
                    netName = netName.Substring(0, netName.IndexOf("-") - 1);
					speed = ni.Speed / 10;
					if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
					{
						//break;
					}
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        //Debug.WriteLine(1);
                        break;
                    }
				}
			}

			network = new ManagementObject("Win32_PerfFormattedData_Tcpip_NetworkInterface.Name='" + netName + "'");
            */
            network = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_Tcpip_NetworkInterface");

		}

		public override double NextValue()
        {
            double networkspeed = 0;
            int count = 0;
            foreach (ManagementObject share in network.Get())
            {
                networkspeed += double.Parse(share.Properties["BytesTotalPerSec"].Value.ToString()) / 1000;

                if (count > 1)
                {
                    break;
                }
                else
                {
                    count++;
                }
               
            }
            return networkspeed;
		}
	}
}
