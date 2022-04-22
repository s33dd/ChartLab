using System;

namespace ChartLabFramework {
  public class Cycloid {
    private double rCoef;
    private double y;
    public double RCoef {
      get { return this.rCoef; }
      set { this.rCoef = value; }
    }
    public double Y {
      get { return this.y; }
      set { this.y = value; }
    }

    public double Count() {
      double asinFraction = (rCoef - y) / rCoef;
      double root = Math.Sqrt(2*rCoef*y - y*y);
      double x = rCoef * Math.Acos(asinFraction) - root;
      return x;
    }
  }
}
