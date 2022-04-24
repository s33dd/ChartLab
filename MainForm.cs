using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLabFramework {
  public partial class MainForm : Form {
    private System.Data.DataTable data;
    public MainForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    private int Precision(double value) {
      string step = value.ToString();
      if (step.Contains('E')) {
        step = step.Substring(step.IndexOf('E') + 2);
        return Convert.ToInt32(step);
      }
      else if (step.Contains(',')) {
        step = step.Substring(step.IndexOf(',') + 1);
        return step.Length;
      }
      else {
        return 0;
      }
    }

    private void DrawBtn_Click(object sender, EventArgs e) {
      double? highBorder = null;
      double? lowBorder = null;
      double? step = null;
      double? radius = null;
      double? y = null;
      double? x = null;
      int precision = 0;
      data = null;
      //Input check
      if (RadiusData.Text == "" || HighBorderData.Text == "" || LowBorderData.Text == "" || HighBorderData.Text == "" || StepData.Text == "") {
        MessageBox.Show("Please, fill all fields.", "Error!");
        return;
      }
      try {
        highBorder = Convert.ToDouble(HighBorderData.Text);
        lowBorder = Convert.ToDouble(LowBorderData.Text);
        step = Double.Parse(StepData.Text, NumberStyles.Float);
        radius = Convert.ToDouble(RadiusData.Text);
      }
      catch {
        MessageBox.Show("Please, check your data. There is some problems with it.", "Error!");
        return;
      }
      if (DataProcessing.DataCheck((double)highBorder, (double)lowBorder, (double)radius) == false) {
        return;
      }

      //Creating chart
      try {
        FuncChart.Series["Cycloid"].Points.Clear();
      }
      catch {
        FuncChart.Series.Add("Cycloid");
        FuncChart.ChartAreas.Add("Cycloid");
      }
      FuncChart.Series["Cycloid"].Color = Color.Red;
      FuncChart.Series["Cycloid"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

      //Calculating values
      Cycloid function = new Cycloid();
      function.Radius = (double)radius;
      precision = Precision((double)step);

      //Precision error processing
      if (step <= 0 | precision >= 4) {
        MessageBox.Show("This step will lead to infinite calculation.", "Error!");
        return;
      }
      if (step >= 1) {
        MessageBox.Show("This step is too huge. Chart will be uncorrect.", "Warning!");
      }

      //Drawing chart and adding data to table
      y = lowBorder;
      data = new System.Data.DataTable();
      data.Columns.Add("X");
      data.Columns.Add("Y");
      while (y <= highBorder) {
        DataRow row = data.NewRow();
        row["Y"] = y;
        function.Y = (double)y;
        x = Math.Round(function.Count(), 5);
        row["X"] = x;
        data.Rows.Add(row);
        FuncChart.Series["Cycloid"].Points.AddXY(x, y);
        y += step;
        if (precision != 0) {
          y = Math.Round((double)y, precision);
        }
        else {
          y = Math.Truncate((double)y);
        }
      };
      FuncChart.ChartAreas["Cycloid"].AxisX.Maximum = (double)x + 1;
      FuncChart.ChartAreas["Cycloid"].AxisY.Maximum = (double)y + 1;
    }

    private void TableBtn_Click(object sender, EventArgs e) {
      if (data == null) {
        MessageBox.Show("You need to draw the chart before.", "Warning!");
        return;
      }
      DataTable table = new DataTable();
      table.Data = data;
      table.Show();
    }
  }
}
