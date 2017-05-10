using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace EliteSider
{
    class MemoryPerformanceCounter : CommonPerformanceCounter
    {
        ManagementObjectSearcher memoryCounter;
        //ManagementObject memoryCounter;
        public int totalPhysicalMemory;

        public MemoryPerformanceCounter()
        {
            memoryCounter = new ManagementObjectSearcher("select * from Win32_LogicalMemoryConfiguration");
            foreach (ManagementObject share in memoryCounter.Get())
            {
                totalPhysicalMemory = (int)(double.Parse(share.Properties["TotalPhysicalMemory"].Value.ToString()) / 1024);
                break;
            }
		}

		public override double NextValue()
		{
            //Win32_PerfRawData_PerfOS_Memory AvailableMBytes
            double totalPhysicalMemory = 0;
            ManagementObjectSearcher memoryCounter = new ManagementObjectSearcher("select * from Win32_PerfRawData_PerfOS_Memory");
            foreach (ManagementObject share in memoryCounter.Get())
            {
                totalPhysicalMemory = double.Parse(share.Properties["AvailableMBytes"].Value.ToString());
                break;                
            }

            return totalPhysicalMemory;

		}	
    }
}
