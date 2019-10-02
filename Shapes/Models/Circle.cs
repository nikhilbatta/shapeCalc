using System;

namespace Shapes.Models
 {
public class Circle
{
    public double Radius {get;set;}
    public Circle(int radius)
    {
        Radius = radius;
    }
    public double GetCircumfrance()
    {
        return Math.Round((2 * 3.14) * Radius, 2);
    }
    public double GetDiameter()
    {
        return Math.Round(Radius * 2, 2);
    }
}
}