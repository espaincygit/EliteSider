using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace EliteSider
{
    class CPUPerformanceCounter : CommonPerformanceCounter
    {
        ManagementObjectSearcher cpuCounter;

        ManagementObjectSearcher cpuSpeedCounter;

        public double cpuSpeed;
        //ManagementObject memoryCounter;
        //public double cpuTemp;

        public CPUPerformanceCounter()
        {
            //MSAcpi_ThermalZoneTemperature  Win32_TemperatureProbe CurrentReading  MaxReadable  CIM_NumericSensor
            cpuCounter = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            cpuSpeedCounter = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            //Win32_Processor CurrentClockSpeed
            //cpuCounter = new ManagementObjectSearcher("SELECT * FROM MSAcpi_ThermalZoneTemperature");

            //cpuCounter = new ManagementObjectSearcher("root\\cimv2", "SELECT * FROM Win32_TemperatureProbe");

            //"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature"
		}

		public override double NextValue()
		{
            double cpuTemp = 0;
            try
            {
                foreach (ManagementObject share in cpuCounter.Get())
                {


                    //cpuTemp = double.Parse(share.Properties["CurrentReading"].Value.ToString());

                    cpuTemp = (double.Parse(share.Properties["CurrentTemperature"].Value.ToString()) - 2732) / 10.0;
                    break;
                }
            }
            catch (Exception cpu)
            {
                Debug.WriteLine(cpu.Message);
            }
       
            foreach (ManagementObject share in cpuSpeedCounter.Get())
            {
                // CurrentClockSpeed  MaxClockSpeed
                //foreach (PropertyData pd in share.Properties)
                //{
                //    Debug.WriteLine(pd.Name + "   *********************************     " + pd.Value);
                //}
                this.cpuSpeed = double.Parse(share.Properties["CurrentClockSpeed"].Value.ToString());//CurrentClockSpeed
                break;
            }
            
            return cpuTemp;

		}	
    }
}
