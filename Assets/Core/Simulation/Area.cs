using System;
using System.Runtime.CompilerServices;

namespace Core.Simulation;

internal class Area
{
    public Cell[] Cells;
    public LightSource[] LightSources;

    public Area(int width, int height, int lightSourcesCount)
    {
        CreateCells(width, height);
        CreateLightSources(width, height, lightSourcesCount);
        FillEnergy();
    }

    private void CreateCells(int width, int height)
    {
        Cells = new Cell[width * height];
        int c = 0;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++, c++)
            {
                Cells[c] = new Cell(x, y);
            }
        }
    }

    private void CreateLightSources(int width, int height, int lightSourcesCount)
    {
        var random = new Random();
        LightSources = new LightSource[lightSourcesCount];
        for (int i = 0; i < lightSourcesCount; i++)
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            } while (LightSources.Any(_ => _.X == x && _.Y == y));
            LightSources[i] = new LightSource(x, y);
        }
    }

    private void FillEnergy()
    {
        foreach (var light in LightSources)
        {
            for (int i = 0; i < Cells.Length; i++)
            {
                var cell = Cells[i];
                var distance = (int)Math.Round(Math.Sqrt(Math.Pow(light.X + cell.X, 2) 
                    + Math.Pow(light.Y + cell.Y, 2)));
                if (distance < light.Radius)
                {
                    cell.EnergyLevel += light.Radius - distance;
                }
            }
        }
    }
}
