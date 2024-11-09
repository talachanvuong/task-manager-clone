using TaskManagerClone.Charts;
using TaskManagerClone.Counters;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private CpuCounter cpuCounter = new();
		private CpuChart cpuChart = new();

		private void UpdateCpuTab()
		{
			double utilization = cpuCounter.GetUtilization();
			double speed = cpuCounter.GetSpeed();
			string name = cpuCounter.GetName();

			string processes = cpuCounter.GetProcesses().ToString();
			string threads = cpuCounter.GetThreads().ToString();
			string handles = cpuCounter.GetHandles().ToString();
			string upTime = cpuCounter.GetUpTime();

			SafeInvoke(() =>
			{
				cpuNameLabel.Text = name;
				cpuUtilizationLabel.Text = $"{utilization}%";
				cpuSpeedLabel.Text = $"{speed} GHz";

				cpuProcessesLabel.Text = processes;
				cpuThreadsLabel.Text = threads;
				cpuHandlesLabel.Text = handles;
				cpuUpTimeLabel.Text = upTime;

				cpuChart.UpdateChart(utilization / 100.0);
			});
		}
	}
}