using TaskManagerClone.Charts;
using TaskManagerClone.Counters;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private NetworkCounter networkCounter = new();
		private NetworkChart networkChart = new();

		private void UpdateNetworkTab()
		{
			double bytesToMB = 1024.0 * 1024.0;

			double total = networkCounter.GetTotal() / bytesToMB;
			string type = networkCounter.GetNetworkType();
			string name = networkCounter.GetName();
			double send = networkCounter.GetSend() / bytesToMB;
			double receive = networkCounter.GetReceive() / bytesToMB;

			SafeInvoke(() =>
			{
				networkTypeLabel.Text = type;
				networkNameLabel.Text = name;
				networkSendLabel.Text = $"{send} Mbps";
				networkReceiveLabel.Text = $"{receive} Mbps";
				networkTotalLabel.Text = $"{total} Mbps";

				networkChart.UpdateChart(total);
			});
		}
	}
}