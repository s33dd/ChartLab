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
      try {
        FuncChart.Series["Cycloid"].Points.Clear();
      }
      catch {
        FuncChart.Series.Add("Cycloid");
      }
      if (RCoefData.Text == "" || YData.Text == "" || HighBorderData.Text == "" || LowBorderData.Text == "" || HighBorderData.Text == "" || StepData.Text == "") {
        MessageBox.Show("Please fill all fields.", "Error!");
        return;
      }
      FuncChart.Series["Cycloid"].Color = Color.Red;
      FuncChart.Series["Cycloid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      Cycloid function = new Cycloid();
    }
  }
}
