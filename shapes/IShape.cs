namespace NETGeometryExercises.Shapes
{
    public interface IShape
    {
        string Name { get; }
        double GetLateralArea();
        double GetSurfaceArea();
        double GetVolume();
    }
}
