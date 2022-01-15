using Eto.Drawing;
using Eto.Forms;
using System;

namespace Eto.Microcharts.Demo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			var charts = new SampleCharts().Charts;

			var layout2 = new DynamicLayout
			{
				Spacing = Size.Empty + 2,
				Rows = {
					new DynamicRow(view(charts[0]), view(charts[1]), view(charts[2])),
					new DynamicRow(view(charts[3]), view(charts[4]), view(charts[5]))
				}
			};
			layout2.SizeChanged += (o, e) => {
				var chart_size = layout2.Size / new Size(3, 2);
				foreach (var c in layout2.Controls)
					c.Size = chart_size;
			};

			var entries = new global::Microcharts.ChartEntry[]
				{
					new global::Microcharts.ChartEntry(200) { Label = "January", ValueLabel = "200", Color = SkiaSharp.SKColors.CornflowerBlue },
					new global::Microcharts.ChartEntry(400) { Label = "February", ValueLabel = "400", Color = SkiaSharp.SKColors.ForestGreen },
					new global::Microcharts.ChartEntry(-100) { Label = "March", ValueLabel = "-100", Color = SkiaSharp.SKColors.MediumVioletRed }
				};
			this.Content = new Eto.Microcharts.ChartView() { Chart = new global::Microcharts.RadarChart { Entries = entries, AnimationProgress = 100 } };

			Content = layout2;
		}

		private Control view(global::Microcharts.Chart chart)
		{
			chart.AnimationProgress = 100;

			return new ChartView { Chart = chart  };
		}
	}
}
