namespace NETGeometryExercises.Shapes
{
    public interface IShape
    {
        string Name { get; }
        double GetSurfaceArea();
        double GetVolume();
    }
}
