using System.Diagnostics;
using System.Management;

namespace TaskManagerClone.Counters
{
	public class DiskCounter
	{
		private PerformanceCounter idleTimeCounter = new(
			"PhysicalDisk",
			"% Idle Time",
			"_Total"
		);

		private PerformanceCounter responseTimeCounter = new(
			"PhysicalDisk",
			"Avg. Disk sec/Transfer",
			"_Total"
		);

		private PerformanceCounter readSpeedCounter = new(
			"PhysicalDisk",
			"Disk Read Bytes/sec",
			"_Total"
		);

		private PerformanceCounter writeSpeedCounter = new(
			"PhysicalDisk",
			"Disk Write Bytes/sec",
			"_Total"
		);

		public double GetActiveTime()
		{
			var result = 100.0 - idleTimeCounter.NextValue();
			return Math.Clamp(result, 0.0, 100.0);
		}

		public double GetResponseTime()
		{
			return responseTimeCounter.NextValue();
		}

		public double GetReadSpeed()
		{
			return readSpeedCounter.NextValue();
		}

		public double GetWriteSpeed()
		{
			return writeSpeedCounter.NextValue();
		}

		public dynamic GetDiskInfo()
		{
			string name = "N/A";
			UInt64 size = 0;
			string type = "N/A";
			UInt64 cylinder = 0;
			UInt32 head = 0;
			UInt64 sector = 0;
			UInt64 track = 0;

			var query = $@"SELECT Model, Size, MediaType, TotalCylinders, TotalHeads, TotalSectors, TotalTracks
						   FROM Win32_DiskDrive";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			foreach (var item in result)
			{
				name = (string)item["Model"];
				size = (UInt64)item["Size"];
				type = (string)item["MediaType"];
				cylinder = (UInt64)item["TotalCylinders"];
				head = (UInt32)item["TotalHeads"];
				sector = (UInt64)item["TotalSectors"];
				track = (UInt64)item["TotalTracks"];
				break;
			}

			return new
			{
				Name = name,
				Size = size,
				Type = type,
				Cylinder = cylinder,
				Head = head,
				Sector = sector,
				Track = track
			};
		}
	}
}