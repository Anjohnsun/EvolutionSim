namespace Interfaces.Dto;

internal class CellDto
{
    public int X { get; }
    public int Y { get; }
    public int EnergyLevel { get; set; }

    public CellDto(int x, int y, int energyLevel)
    {
        X = x;
        Y = y;
        EnergyLevel = energyLevel;
    }
}
