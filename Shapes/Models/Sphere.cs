using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public Circle SomeCircle {get;set;}

        public Sphere(Circle aCircle)
        {
            SomeCircle = aCircle;
        }
        public double GetVolume()
        {
            return  (double)((4/3) * 3.14 * (Math.Pow(SomeCircle.Radius, 3)));
            
        }
        public double SurfaceArea()
        {
            return  (double)((4 * 3.14) * Math.Pow(SomeCircle.Radius,2));
        }
    }
}