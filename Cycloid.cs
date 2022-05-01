using System;

namespace ChartLabFramework {
  public class Cycloid {
    private double radius;
    private double y;
    public double Radius {
      get { return this.radius; }
      set { this.radius = value; }
    }
    public double Y {
      get { return this.y; }
      set { this.y = value; }
    }

    public double Count() {
      double asinFraction = (radius - y) / radius;
      double root = Math.Sqrt(2*radius*y - y*y);
      double x = radius * Math.Acos(asinFraction) - root;
      return x;
    }
  }
}
