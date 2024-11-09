using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;

namespace TaskManagerClone.Charts
{
	public class GpuChart
	{
		private PlotModel plotModel;
		private DateTimeAxis xAxis;
		private LinearAxis yAxis;
		private FunctionSeries functionSeries0;
		private FunctionSeries functionSeries1;

		public GpuChart()
		{
			plotModel = new PlotModel();

			xAxis = new DateTimeAxis
			{
				Position = AxisPosition.Bottom,
				StringFormat = "HH:mm:ss"
			};

			yAxis = new LinearAxis
			{
				Position = AxisPosition.Left,
				StringFormat = "0%",
				Minimum = 0,
				Maximum = 1
			};

			functionSeries0 = new FunctionSeries
			{
				Title = "GPU 0",
				Color = OxyColors.Green,
				StrokeThickness = 2.0,
			};

			functionSeries1 = new FunctionSeries
			{
				Title = "GPU 1",
				Color = OxyColors.Blue,
				StrokeThickness = 2.0
			};

			plotModel.Axes.Add(xAxis);
			plotModel.Axes.Add(yAxis);
			plotModel.Series.Add(functionSeries0);
			plotModel.Series.Add(functionSeries1);
			plotModel.Legends.Add(new Legend
			{
				LegendPosition = LegendPosition.TopRight
			});
		}

		public void SetToView(PlotView plotView)
		{
			plotView.Model = plotModel;
		}

		public void UpdateChart0(double value)
		{
			// Get min time
			double minTime = DateTimeAxis.ToDouble(DateTime.Now.AddMinutes(-1.0));

			// Update min time
			xAxis.Minimum = minTime;

			// Update new value
			var newPoint = new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), value);
			functionSeries0.Points.Add(newPoint);

			// Remove old points0
			functionSeries0.Points.RemoveAll(point => point.X < minTime);

			// Re-render plot view
			plotModel.InvalidatePlot(true);
		}

		public void UpdateChart1(double value)
		{
			// Get min time
			double minTime = DateTimeAxis.ToDouble(DateTime.Now.AddMinutes(-1.0));

			// Update min time
			xAxis.Minimum = minTime;

			// Update new value
			var newPoint = new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), value);
			functionSeries1.Points.Add(newPoint);

			// Remove old points
			functionSeries1.Points.RemoveAll(point => point.X < minTime);

			// Re-render plot view
			plotModel.InvalidatePlot(true);
		}
	}
}