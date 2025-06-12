namespace Core.Simulation;

internal class LightSource
{
    public int X { get; }
    public int Y { get; }
    public int Radius { get; }

    public LightSource(int x, int y)
    {
        X = x;
        Y = y;
        Radius = 10;
    }
}
