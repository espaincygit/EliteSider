using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EliteSider
{
	class CommonPerformanceCounter
	{
		PerformanceCounter p;
		
		public CommonPerformanceCounter()
		{
			p = new PerformanceCounter();
		}

		public CommonPerformanceCounter(string categoryName, string counterName)
		{
			p = new PerformanceCounter(categoryName, counterName);
		}

		public CommonPerformanceCounter(string categoryName, string counterName, bool readOnly)
		{
			p = new PerformanceCounter(categoryName, counterName, readOnly);
		}

		public CommonPerformanceCounter(string categoryName, string counterName, string instanceName)
		{
			p = new PerformanceCounter(categoryName, counterName, instanceName);
		}

		public CommonPerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly)
		{
			p = new PerformanceCounter(categoryName, counterName, instanceName, readOnly);
		}

		public CommonPerformanceCounter(string categoryName, string counterName, string instanceName, string machineName)
		{
			p = new PerformanceCounter(categoryName, counterName, instanceName, machineName);
		}

		public virtual double NextValue()
		{
			return p.NextValue();
		}
	}
}
