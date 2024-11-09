using System.Diagnostics;
using System.Management;

namespace TaskManagerClone.Counters
{
	public class MemoryCounter
	{
		private PerformanceCounter availableCounter = new(
			"Memory",
			"Available Bytes"
		);

		public double GetUtilization()
		{
			var physicalRam = GetPhysicalRam();
			var available = GetAvailable();
			return (physicalRam - available) / physicalRam;
		}

		public double GetInUse()
		{
			var physicalRam = GetPhysicalRam();
			var available = GetAvailable();
			return physicalRam - available;
		}

		public double GetAvailable()
		{
			return (double)availableCounter.NextValue();
		}

		public UInt64 GetPhysicalRam()
		{
			UInt64 count = 0;

			var query = $@"SELECT TotalPhysicalMemory
						   FROM Win32_ComputerSystem";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				count += (UInt64)item["TotalPhysicalMemory"];	
			}

			return count;
		}

		public UInt32 GetPageFile()
		{
			UInt32 count = 0;

			var query = $@"SELECT AllocatedBaseSize
						   FROM Win32_PageFileUsage";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				count += (UInt32)item["AllocatedBaseSize"];
			}

			return count;
		}

		public string GetSlotsUsedInfo()
		{
			string info = "N/A";

			var query = $@"SELECT *
						   FROM Win32_PhysicalMemory";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			info = $"{result.Count}\n";

			foreach (var item in result)
			{
				info += $"{item["Manufacturer"]} {item["PartNumber"]}\n";
			}

			return info;
		}
	}
}