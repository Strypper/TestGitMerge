using System;

namespace TestGit{
  public class Circle{
    public double Radius { get; set;}
    public double Diameter { get => Radius*2; set => Radius = value / 2;}
    public double Area  { get => Diameter*Math.PI; set => Diameter = value/Math.PI; }

    public double ReturnCircleInfomation(double R)
    {
      this.Radius = R;
      return Area;
    }
  }
}