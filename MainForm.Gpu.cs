using System.Diagnostics;
using TaskManagerClone.Charts;
using TaskManagerClone.Counters;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private GpuCounter gpuCounter = new();
		private GpuChart gpuChart = new();

		private void UpdateGpuTab()
		{
			var hardwareInfos = gpuCounter.GetHardwareInfos();

			SafeInvoke(() =>
			{
				for (int i = 0; i < hardwareInfos.Count; i++)
				{
					var item = hardwareInfos[i];
					double utilization = item.utilization;
					double temperature = item.temperature;
					string name = item.name;

					switch (i)
					{
						case 0:
							gpu0NameLabel.Text = name;
							gpu0UtilizationLabel.Text = $"{utilization}%";
							gpu0TemperatureLabel.Text = $"{temperature}°C";

							gpuChart.UpdateChart0(utilization / 100.0);
							break;

						case 1:
							gpu1NameLabel.Text = name;
							gpu1UtilizationLabel.Text = $"{utilization}%";
							gpu1TemperatureLabel.Text = $"{temperature}°C";

							gpuChart.UpdateChart1(utilization / 100.0);
							break;
					}
				}
			});
		}
	}
}