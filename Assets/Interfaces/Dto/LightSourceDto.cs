namespace Interfaces.Dto;

public class LightSourceDto
{
    public int X { get; }
    public int Y { get; }
    public int Radius { get; }
    public LightSourceDto(int x, int y)
    {
        X = x;
        Y = y;
        Radius = 10;
    }
}
