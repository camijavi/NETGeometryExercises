using System;

namespace NETGeometryExercises.Shapes
{
    public  class RectangularParallelepiped : IShape
    {
        
        public string Name => "Rectangular Parallelepiped";
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }


        public RectangularParallelepiped(double length, double width, double height) {

            Length = length;
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public double GetSurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }
        public double GetVolume()
        {
            return Length * Width * Height;
        }
    }
}
