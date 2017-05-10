using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Management;

namespace EliteSider
{
	//
	// Needed because the PerformanceCounter doesn't work correctly with "% Disk Time"
	// See: http://support.microsoft.com/default.aspx?scid=kb;en-us;324548
	//
	class DiskTimePerformanceCounter : CommonPerformanceCounter
    {
        ManagementObjectSearcher hddCounter;
		//private double prevCountBase = 0;
		//private double prevCountValue = 0;
		//ManagementObject physDiskCounter;
        private int offset;

		public DiskTimePerformanceCounter()
        {
            hddCounter = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData");//CurrentClockSpeed
            foreach (ManagementObject share in hddCounter.Get())
            {

                byte[] hddByte = (byte[])share.Properties["VendorSpecific"].Value;

                byte[] attr = new byte[12];
                int off = 2;
                for (int j = 0; j < hddByte.Length / 12; j++)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        attr[i] = hddByte[off + i];
                    }
                    int attribute = attr[0] & 0xFF;
                    //Attribute 194 contains hard disk drive temperature. 
                    //The raw value of this attribute shows built-in heat 
                    //sensor value in in degrees centigrade. 
                    if (attribute == 194)
                    {
                        //diskTemp = attr[5]; 
                        //Debug.WriteLine("disk temperature=" + attr[5] + " C");
                        //hddTemp = double.Parse(attr[5].ToString());
                        offset = off + 5;
                        break;
                    }
                    off += 12;
                }

                //Debug.WriteLine("VendorSpecific" + hddByte[151].ToString());

                //hddTemp = double.Parse(hddByte[151].ToString());
                break;
            }																																								
		}

		public override double NextValue()
		{
			/*physDiskCounter.Get();
			double newCountBase = (double)(ulong)physDiskCounter.Properties["PercentDiskTime_Base"].Value;
			double newCountValue = (double)(ulong)physDiskCounter.Properties["PercentDiskTime"].Value;
			double result = ((prevCountValue - newCountValue) / (prevCountBase - newCountBase)) * 100;
			prevCountBase = newCountBase;
			prevCountValue = newCountValue;
			return result;*/


            double hddTemp = 0;

            foreach (ManagementObject share in hddCounter.Get())
            {

                //foreach (PropertyData pd in share.Properties)
                //{
                //    Debug.WriteLine(pd.Name + "   *********************************     " + pd.Value);
                //}
                byte[] hddByte = (byte[])share.Properties["VendorSpecific"].Value;

                        //diskTemp = attr[5]; 
                        //Debug.WriteLine("disk temperature=" + attr[5] + " C");
                hddTemp = double.Parse(hddByte[offset].ToString());
               

                //Debug.WriteLine("VendorSpecific" + hddByte[151].ToString());
                
                //hddTemp = double.Parse(hddByte[151].ToString());
                break;
            }

            return hddTemp;

		}																																				
	}
}
																							