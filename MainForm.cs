using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChartLabFramework {
  public partial class MainForm : Form {
    private System.Data.DataTable data;
    private double? highBorder = null;
    private double? lowBorder = null;
    private double? step = null;
    private double? radius = null;
    private double? y = null;
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
      highBorder = null;
      lowBorder = null;
      step = null;
      radius = null;
      y = null;
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

    private void MainForm_Load(object sender, EventArgs e) {
      if (!Properties.Settings.Default.NotShow) {
        AboutForm about = new AboutForm();
        about.ShowDialog();
      }
    }

    private void saveInitToolStripMenuItem_Click(object sender, EventArgs e) {
      SaveInit.Filter = "txt files (*.txt)|*.txt";
      if (RadiusData.Text == "" || HighBorderData.Text == "" || LowBorderData.Text == "" || HighBorderData.Text == "" || StepData.Text == "") {
        MessageBox.Show("Please, fill all fields.", "Error!");
        return;
      }
      if (SaveInit.ShowDialog() == DialogResult.OK) {
        string filepath = SaveInit.FileName;
        using (StreamWriter writer = new StreamWriter(filepath, false)) {
          writer.WriteLine(RadiusData.Text);
          writer.WriteLine(LowBorderData.Text);
          writer.WriteLine(HighBorderData.Text);
          writer.WriteLine(StepData.Text);
        }
      }
    }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
      OpenFile.Filter = "txt files (*.txt)|*.txt";
      if (OpenFile.ShowDialog() == DialogResult.OK) {
        var stream = OpenFile.OpenFile();
        using (StreamReader reader = new StreamReader(stream)) {
          RadiusData.Text = reader.ReadLine();
          LowBorderData.Text = reader.ReadLine();
          HighBorderData.Text = reader.ReadLine();
          StepData.Text = reader.ReadLine();
        }
      }
    }

    private void saveResultToolStripMenuItem_Click(object sender, EventArgs e) {
      SaveResult.Filter = "txt files (*.txt)|*.txt";
      if (data == null) {
        MessageBox.Show("Nothing to save!", "Error!");
        return;
      }
      if (SaveResult.ShowDialog() == DialogResult.OK) { 
        string filepath = SaveResult.FileName;
        using (StreamWriter writer = new StreamWriter(filepath, false)) {
          writer.WriteLine("X               Y");
          foreach (DataRow row in data.Rows) {
            writer.WriteLine($"{row["X"]}               {row["Y"]}");
          }
        }
      }
    }
  }
}
