using LibreHardwareMonitor.Hardware;

namespace TaskManagerClone.Counters
{
	public class GpuCounter
	{
		public struct HardwareInfo
		{
			public string name;
			public double utilization;
			public double temperature;
		}

		public List<HardwareInfo> GetHardwareInfos()
		{
			var result = new List<HardwareInfo>();

			var computer = new Computer
			{
				IsGpuEnabled = true
			};
			computer.Open();

			foreach (var hardware in computer.Hardware)
			{
				hardware.Update();

				var newInfo = new HardwareInfo
				{
					name = hardware.Name
				};

				foreach (var sensor in hardware.Sensors)
				{
					if (sensor.Name.Contains("GPU Core") || sensor.Name.Contains("D3D 3D"))
					{
						switch (sensor.SensorType)
						{
							case SensorType.Temperature:
								newInfo.temperature = sensor.Value ?? 0.0;
								break;

							case SensorType.Load:
								newInfo.utilization = sensor.Value ?? 0.0;
								break;
						}
					}

					if (newInfo.utilization != 0.0 && newInfo.temperature != 0.0)
					{
						break;
					}
				}

				result.Add(newInfo);
			}

			return result;
		}
	}
}