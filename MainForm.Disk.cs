using TaskManagerClone.Charts;
using TaskManagerClone.Counters;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private DiskCounter diskCounter = new();
		private DiskChart diskChart = new();

		private void UpdateDiskTab()
		{
			double bytesToMB = 1024.0 * 1024.0;
			double bytesToGB = 1024.0 * 1024.0 * 1024.0;

			double activeTime = diskCounter.GetActiveTime();
			double responseTime = diskCounter.GetResponseTime() * 1000.0;
			double readSpeed = diskCounter.GetReadSpeed() / bytesToMB;
			double writeSpeed = diskCounter.GetWriteSpeed() / bytesToMB;
			
			var diskInfo = diskCounter.GetDiskInfo();
			string name = diskInfo.Name;
			double capacity = diskInfo.Size / bytesToGB;
			string type = diskInfo.Type;

			string cylinder = diskInfo.Cylinder.ToString();
			string head = diskInfo.Head.ToString();
			string sector = diskInfo.Sector.ToString();
			string track = diskInfo.Track.ToString();

			SafeInvoke(() =>
			{
				diskActiveTimeLabel.Text = $"{activeTime}%";
				diskResponeTimeLabel.Text = $"{responseTime} ms";
				diskReadSpeedLabel.Text = $"{readSpeed} MB/s";
				diskWriteSpeedLabel.Text = $"{writeSpeed} MB/s";

				diskNameLabel.Text = name;
				diskCapacityLabel.Text = $"{capacity} GB";
				diskTypeLabel.Text = type;

				diskCylindersLabel.Text = cylinder;
				diskHeadsLabel.Text = head;
				diskSectorsLabel.Text = sector;
				diskTracksLabel.Text = track;

				diskChart.UpdateChart(activeTime / 100.0);
			});
		}
	}
}