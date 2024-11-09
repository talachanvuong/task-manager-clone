using System.Diagnostics;
using System.Management;

namespace TaskManagerClone
{
	public class ProcessGetter
	{
		public static IEnumerable<dynamic> GetProcessesInfo(string keyword)
		{
			var query = $@"SELECT Name, ProcessId, ExecutablePath
						   FROM Win32_Process
						   WHERE Name LIKE '%{keyword}%'";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			var processes = result.Cast<ManagementObject>().Select(process =>
			{
				string name = (string)process["Name"];
				UInt32 id = (UInt32)process["ProcessId"];
				string path = (string)process["ExecutablePath"];
				string description = string.Empty;

				Icon defaultIcon = new(SystemIcons.WinLogo, 32, 32);
				Icon icon = defaultIcon;

				if (path is not null)
				{
					description = FileVersionInfo.GetVersionInfo(path).FileDescription ?? string.Empty;
					icon = Icon.ExtractAssociatedIcon(path) ?? defaultIcon;
				}

				return new
				{
					Name = name,
					Id = id,
					Description = description,
					Icon = icon
				};
			});

			return processes;
		}

		public static IEnumerable<dynamic> GetProcessesPerformance()
		{
			var query = @"SELECT IDProcess, PercentProcessorTime, WorkingSetPrivate
						  FROM Win32_PerfFormattedData_PerfProc_Process";

			var searcher = new ManagementObjectSearcher(query);

			var result = searcher.Get();

			var performances = result.Cast<ManagementObject>().Select(process =>
			{
				UInt32 id = (UInt32)process["IDProcess"];
				UInt64 cpu = (UInt64)process["PercentProcessorTime"];
				UInt64 memory = (UInt64)process["WorkingSetPrivate"];

				return new
				{
					Id = id,
					Cpu = cpu,
					Memory = memory
				};
			});

			return performances;
		}

		public static IEnumerable<dynamic> GetProcesses(string keyword)
		{
			var info = GetProcessesInfo(keyword);
			var perfomance = GetProcessesPerformance();

			var result = from i in info
						 join p in perfomance
						 on i.Id equals p.Id
						 select new
						 {
							 i.Name,
							 i.Id,
							 p.Cpu,
							 p.Memory,
							 i.Description,
							 i.Icon
						 };

			return result;
		}
	}
}