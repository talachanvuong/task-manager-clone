using TaskManagerClone.Charts;
using TaskManagerClone.Counters;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private MemoryCounter memoryCounter = new();
		private MemoryChart memoryChart = new();

		private void UpdateMemoryTab()
		{
			double bytesToGB = 1024.0 * 1024.0 * 1024.0;

			double utilization = memoryCounter.GetUtilization();
			double inUse = memoryCounter.GetInUse() / bytesToGB;
			double available = memoryCounter.GetAvailable() / bytesToGB;
			double physicalRam = memoryCounter.GetPhysicalRam() / bytesToGB;
			double pageFile = memoryCounter.GetPageFile() / 1024.0;
			string slotsUsed = memoryCounter.GetSlotsUsedInfo();

			SafeInvoke(() =>
			{
				memoryUtilizationLabel.Text = $"{utilization * 100.0}%";
				memoryInUseLabel.Text = $"{inUse} GB";
				memoryAvailableLabel.Text = $"{available} GB";
				memoryPhysicalRamLabel.Text = $"{physicalRam} GB";
				memoryPageFileLabel.Text = $"{pageFile} GB";
				memorySlotsUsedLabel.Text = slotsUsed;

				memoryChart.UpdateChart(utilization);
			});
		}
	}
}