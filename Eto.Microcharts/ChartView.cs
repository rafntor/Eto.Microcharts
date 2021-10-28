
using Microcharts;
using SkiaSharp;
using Eto.SkiaDraw;

namespace Eto.Microcharts
{
	public class ChartView : SkiaDrawable
	{
		Chart? _chart;
		public ChartView()
		{
		}

		public Chart? Chart
		{
			get => _chart;
			set
			{
				_chart = value;
				this.Invalidate();
			}
		}
		protected override void OnPaint(SKCanvas canvas)
		{
			if (_chart != null)
				_chart.Draw(canvas, Width, Height);
			else
				canvas.Clear();
		}
	}
}
