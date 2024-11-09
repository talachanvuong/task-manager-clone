using System.Diagnostics;
using System.Management;

namespace TaskManagerClone.Counters
{
	public class CpuCounter
	{
		private PerformanceCounter utilizationCounter = new
		(
			"Processor Information",
			"% Processor Utility",
			"_Total"
		);

		private PerformanceCounter speedCounter = new
		(
			"Processor Information",
			"% Processor Performance",
			"_Total"
		);

		public string GetName()
		{
			string name = "N/A";

			var query = $@"SELECT Name
						   FROM Win32_Processor";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				name = (string)item["Name"];
				break;
			}

			return name;
		}

		public double GetUtilization()
		{
			return (double)utilizationCounter.NextValue();
		}

		private UInt32 GetBaseSpeed()
		{
			UInt32 speed = 0;

			var query = $@"SELECT MaxClockSpeed
						   FROM Win32_Processor";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				speed = (UInt32)item["MaxClockSpeed"];
				break;
			}

			return speed;
		}

		public double GetSpeed()
		{
			var speed = speedCounter.NextValue();
			var baseSpeed = GetBaseSpeed();

			var speedMHz = speed / 100.0 * baseSpeed;
			var speedGHz = speedMHz / 1000.0;

			return speedGHz;
		}

		public int GetProcesses()
		{
			var query = $@"SELECT *
						   FROM Win32_Process";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			return result.Count;
		}

		public UInt32 GetThreads()
		{
			UInt32 count = 0;

			var query = $@"SELECT ThreadCount
						   FROM Win32_Process";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				count += (UInt32)item["ThreadCount"];
			}

			return count;
		}

		public UInt32 GetHandles()
		{
			UInt32 count = 0;

			var query = $@"SELECT HandleCount
						   FROM Win32_Process";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				count += (UInt32)item["HandleCount"];
			}

			return count;
		}

		public string GetUpTime()
		{
			string time = "N/A";

			var query = $@"SELECT LastBootUpTime
						   FROM Win32_OperatingSystem";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				var lastBootUpTimeText = (string)item["LastBootUpTime"];
				var lastBootUpTime = ManagementDateTimeConverter.ToDateTime(lastBootUpTimeText);
				var timeSpan = DateTime.Now - lastBootUpTime;
				time = $"{timeSpan.Days} Days, {timeSpan.Hours} Hours, {timeSpan.Minutes} Minutes, {timeSpan.Seconds} Seconds";
				break;
			}

			return time;
		}
	}
}