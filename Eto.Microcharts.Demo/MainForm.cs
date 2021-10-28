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

			Content = new ChartView();
		}

		private void SwitchContent()
		{
			var control = Content as ChartView;

			control.Chart = _vm.Charts[++_idx % _vm.Charts.Length];
		}

		SampleCharts _vm = new SampleCharts();
		int _idx = 0;
	}
}
