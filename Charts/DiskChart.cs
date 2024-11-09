using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace TaskManagerClone.Charts
{
	public class DiskChart
	{
		private PlotModel plotModel;
		private DateTimeAxis xAxis;
		private LinearAxis yAxis;
		private FunctionSeries functionSeries;

		public DiskChart()
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

			functionSeries = new FunctionSeries
			{
				Color = OxyColors.Green,
				StrokeThickness = 2.0
			};

			plotModel.Axes.Add(xAxis);
			plotModel.Axes.Add(yAxis);
			plotModel.Series.Add(functionSeries);
		}

		public void SetToView(PlotView plotView)
		{
			plotView.Model = plotModel;
		}

		public void UpdateChart(double value)
		{
			// Get min time
			double minTime = DateTimeAxis.ToDouble(DateTime.Now.AddMinutes(-1.0));

			// Update min time
			xAxis.Minimum = minTime;

			// Update new value
			var newPoint = new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), value);
			functionSeries.Points.Add(newPoint);

			// Remove old points
			functionSeries.Points.RemoveAll(point => point.X < minTime);

			// Re-render plot view
			plotModel.InvalidatePlot(true);
		}
	}
}
