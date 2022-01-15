
namespace Eto.Microcharts.Demo
{
	using Eto.Forms;
	using Eto.Drawing;
	using Microcharts;
	public partial class MainForm : Form
	{
		global::Microcharts.Chart[] charts = new SampleCharts().Charts;
		public MainForm()
		{
			InitializeComponent();

			var layout1 = new TableLayout() { Spacing = Size.Empty + 4 };
			layout1.Rows.Add(new TableRow(cell(0), cell(1), cell(2)) { ScaleHeight = true });
			layout1.Rows.Add(new TableRow(cell(3), cell(4), cell(5)) { ScaleHeight = true });

			var entries = new global::Microcharts.ChartEntry[]
				{
					new global::Microcharts.ChartEntry(200) { Label = "January", ValueLabel = "200", Color = SkiaSharp.SKColors.CornflowerBlue },
					new global::Microcharts.ChartEntry(400) { Label = "February", ValueLabel = "400", Color = SkiaSharp.SKColors.ForestGreen },
					new global::Microcharts.ChartEntry(-100) { Label = "March", ValueLabel = "-100", Color = SkiaSharp.SKColors.MediumVioletRed }
				};
			this.Content = new Eto.Microcharts.ChartView() { Chart = new global::Microcharts.RadarChart { Entries = entries, AnimationProgress = 100 } };

			Content = layout1;
		}

		private TableCell cell (int idx)
		{
			var view = new ChartView { Chart = charts[idx] };

			view.Chart.AnimationProgress = 100;

			return new TableCell(view, true);
		}
	}
}
