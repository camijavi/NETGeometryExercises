using System;

namespace NETGeometryExercises.Shapes
{
    public class Cylinder : IShape
    {
        public string Name => "Cylinder";
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetLateralArea() => 2 * Math.PI * Radius * Height;

        public double GetBaseArea() => Math.PI * Math.Pow(Radius, 2);

        public double GetSurfaceArea() => GetLateralArea() + 2 * GetBaseArea();

        public double GetVolume() => GetBaseArea() * Height;
    }
}
