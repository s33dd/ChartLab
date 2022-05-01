using System;
using System.Windows.Forms;

namespace ChartLabFramework {
  public static class DataProcessing {
    public static bool DataCheck(double highBorder, double lowBorder, double radius) {
      if (radius == 0) {
        MessageBox.Show("Radius can`t be 0!", "Error!");
        return false;
      }
      if (highBorder < lowBorder) {
        MessageBox.Show("High border can`t be less than low border", "Error!");
        return false;
      }
      if (highBorder == lowBorder) {
        MessageBox.Show("Borders can`t be equal.", "Error!");
        return false;
      }
      if (radius > 0 && lowBorder < 0) {
        MessageBox.Show("If radius is positive, low border can`t be less than zero", "Error!");
        return false;
      }
      else if (radius < 0 && highBorder > 0) {
        MessageBox.Show("If radius is negative, high border can`t be more than zero", "Error!");
        return false;
      }
      if (radius > 0 && highBorder > 2 * radius) {
        MessageBox.Show("If radius is positive, high border can`t be more than two radius.", "Error!");
        return false;
      }
      else if (radius < 0 && Math.Abs(lowBorder) > Math.Abs(radius) * 2) {
        MessageBox.Show("If radius is negative, absolute of low border can`t be more than absolute of two radius.", "Error!");
        return false;
      }
      return true;
    }
  }
}
