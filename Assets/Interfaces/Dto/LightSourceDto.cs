namespace Interfaces.Dto;

public class LightSourceDto
{
    public int X { get; }
    public int Y { get; }
    public int Radius { get; }
<<<<<<< HEAD
    public LightSourceDto(int x, int y)
    {
        X = x;
        Y = y;
        Radius = 10;
=======
    public LightSourceDto(int x, int y, int radius)
    {
        X = x;
        Y = y;
        Radius = radius;
>>>>>>> 03cfd0f
    }
}
