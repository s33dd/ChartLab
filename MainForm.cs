using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLabFramework {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      string message = $"Program was made by Sukhoverikov Denis{Environment.NewLine}" +
        $"var 6 'Cycloid chart'";
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    private void DrawBtn_Click(object sender, EventArgs e) {
      double? highBorder = null;
      double? lowBorder = null;
      double? step = null;
      double? radius = null;
      double? y = null;
      double? x = null;
      try {
        FuncChart.Series["Cycloid"].Points.Clear();
      }
      catch {
        FuncChart.Series.Add("Cycloid");
      }
      if (RadiusData.Text == "" || HighBorderData.Text == "" || LowBorderData.Text == "" || HighBorderData.Text == "" || StepData.Text == "") {
        MessageBox.Show("Please, fill all fields.", "Error!");
        return;
      }
      try {
        highBorder = Convert.ToDouble(RadiusData.Text);
        lowBorder = Convert.ToDouble(LowBorderData.Text);
        step = Convert.ToDouble(StepData.Text);
        radius = Convert.ToDouble(RadiusData.Text);
      }
      catch {
        MessageBox.Show("Please, check your data. There is some problems with it.", "Error!");
      }
      FuncChart.Series["Cycloid"].Color = Color.Red;
      FuncChart.Series["Cycloid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      Cycloid function = new Cycloid();
      function.Radius = (double)radius;
      y = lowBorder;
      while (y <= highBorder) {
        function.Y = (double)y;
        x = function.Count();
        FuncChart.Series["Cycloid"].Points.AddXY(x, y);
        y += step;
      };
      //Borders problem, small values problem
    }
  }
}
