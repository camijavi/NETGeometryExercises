using System;

namespace NETGeometryExercises.Shapes
{
    public class RectangularParallelepiped : IShape
    {
        public string Name => "Rectangular Parallelepiped";
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangularParallelepiped(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double GetLateralArea() => 2 * Height * (Length + Width);

        public double GetSurfaceArea() => GetLateralArea() + 2 * (Length * Width);

        public double GetVolume() => Length * Width * Height;
    }
}
