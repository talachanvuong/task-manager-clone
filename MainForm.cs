using OxyPlot;

namespace TaskManagerClone
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetChartToPlotViews();
			BlockInteractPlotViews();
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0:
					Width = 1380;
					tabControl.Width = 1338;
					break;

				default:
					Width = 750;
					tabControl.Width = 708;
					break;
			}
		}

		private async void performanceTimer_Tick(object sender, EventArgs e)
		{
			var cpuTask = Task.Run(() => UpdateCpuTab());
			var memoryTask = Task.Run(() => UpdateMemoryTab());
			var diskTask = Task.Run(() => UpdateDiskTab());
			var networkTask = Task.Run(() => UpdateNetworkTab());
			var gpuTask = Task.Run(() => UpdateGpuTab());

			await Task.WhenAll(cpuTask, memoryTask, diskTask, networkTask, gpuTask);
		}

		private void SetChartToPlotViews()
		{
			// CPU tab
			cpuChart.SetToView(cpuPlotView);

			// Memory tab
			memoryChart.SetToView(memoryPlotView);

			// Disk tab
			diskChart.SetToView(diskPlotView);

			// Network tab
			networkChart.SetToView(networkPlotView);

			// GPU tab
			gpuChart.SetToView(gpuPlotView);
		}

		private void BlockInteractPlotViews()
		{
			var plotController = new PlotController();
			plotController.UnbindAll();

			cpuPlotView.Controller = plotController;
			memoryPlotView.Controller = plotController;
			diskPlotView.Controller = plotController;
			networkPlotView.Controller = plotController;
			gpuPlotView.Controller = plotController;
		}

		private void SafeInvoke(Action action)
		{
			if (InvokeRequired)
			{
				BeginInvoke(delegate
				{
					if (!IsDisposed)
					{
						action();
					}
				});
			}
			else
			{
				if (!IsDisposed)
				{
					action();
				}
			}
		}
	}
}