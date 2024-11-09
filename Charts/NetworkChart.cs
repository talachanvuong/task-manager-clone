using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;

namespace TaskManagerClone.Charts
{
	public class NetworkChart
	{
		private PlotModel plotModel;
		private DateTimeAxis xAxis;
		private FunctionSeries functionSeries;

		public NetworkChart()
		{
			plotModel = new PlotModel();

			xAxis = new DateTimeAxis
			{
				Position = AxisPosition.Bottom,
				StringFormat = "HH:mm:ss"
			};

			functionSeries = new FunctionSeries
			{
				Color = OxyColors.Green,
				StrokeThickness = 2.0
			};

			plotModel.Axes.Add(xAxis);
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