using System;

namespace NETGeometryExercises.Shapes
{
    public class Cone : IShape
    {

        public string Name => "Cone";
        public double Generatrix { get; set} null;
        public double Radius { get; set; }
        public double Height { get; set; }
        double pi = Math.PI;
        
        
        double Generatrix = Math.Sqrt(Radius* Radius + Height* Height);


        public Cone (double generatrix, double radius, double height)
        {

            Generatrix = generatrix;
            Radius = radius;
            Height = height;
        }

        public double GetLateralArea()
        {
            return pi * Radius * Generatrix;
        }

        public double GetBaseArea()
        {
            return pi * Radius * Radius;
        }

        public double GetSurfaceArea() => GetLateralArea() + GetBaseArea();

        public double GetVolume()
        {
            return (GetBaseArea() * Height) / 3;
        }
    }
}
