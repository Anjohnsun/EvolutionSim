using Core.GenethicAlgorythm;

namespace Core.Simulation;

internal class Simulation
{
    public Population Population { get; private set; }
    public Area Area { get; }
    public int GenerationCount { get; }

    public Simulation(int populationSize, int height, int width, int lightSourcesCount, int generationCount)
    {
        Population = new Population(populationSize);
        GenerationCount = generationCount;
        Area = new Area(width, height, lightSourcesCount);
    }

    public void Simulate()
    {
        for (int i = 0; i < GenerationCount; i++)
        {
            while (!Population.IsEnd)
            {
                Population.Run(Area);
            }
            Population.CreateNewPopulation();
        }
    }
}
