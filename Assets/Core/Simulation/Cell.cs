namespace Core.Simulation;

internal class Cell
{
    public int X { get; }
    public int Y { get; }
    public int EnergyLevel { get; set; }

    public Cell(int x, int y)
    {
        X = x;
        Y = y;
        EnergyLevel = 0;
    }
}
