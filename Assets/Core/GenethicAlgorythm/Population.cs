using Core.Actions;
using Core.Simulation;
using System;
using System.Drawing;

namespace Core.GenethicAlgorythm;

internal class Population
{
    public Individ[] Individs { get; }
    public int Size => Individs.Length;
    public bool IsEnd => Individs.All(_ => _.HP == 0);
    public Population(int size)
    {
        Individs = new Individ[size];
        var random = new Random();
        for (int i = 0; i < size; i++)
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, size);
                y = random.Next(0, size);
            } while (Individs.Any(_ => _.X == x && _.Y == y));
            double[] coefficients = new double[IndividFunctions.FunctionSize];
            for (int j = 0; i < coefficients.Length; i++)
            {
                coefficients[i] = random.NextDouble() * 2 - 1;
            }
            Individs[i] = new Individ(x, y, coefficients);
        }
    }

    public void Run(Area area)
    {
        foreach (var ind in Individs)
        {
            var cellsAround = area.Cells.Where(_ => Math.Abs(_.X - ind.X) <= 1 || Math.Abs(_.Y - ind.Y) <= 1).ToArray();
            var functionResult = IndividFunctions.MoveFunction(ind.Coefficients, 
                cellsAround.Select(_ => (double)_.EnergyLevel)
                .Union([ind.Energy]).ToArray());
            var action = IndividActionFabric.GetAction(functionResult);
            action.DoAction(ind);
        }
    }

    public void CreateNewPopulation()
    {
        var indsForBreeding = Selection();
        Breeding(indsForBreeding);
        Mutation();
    }
    private Individ[] Selection()
    {
        var rnd = new Random();
        var summ = Individs.Sum(_ => _.GetFitness());
        var individsWithProbability = Individs.Select(_ => new IndividWithProbability(_, _.GetFitness() / summ))
            .ToList();
        Individ[] individsForBreeding = new Individ[Size / 2];
        for (int i = 0; individsForBreeding[^1] != null; i++)
        {
            if (i == Size)
            {
                i = 0;
            }
            var ind = individsWithProbability[i];
            if (rnd.NextDouble() < ind.Probability)
            {
                individsForBreeding[i] = ind.Individ;
            }
        }
        return individsForBreeding;
    }
    private void Breeding(Individ[] individsForBreeding)
    {
        var random = new Random();
        for (int i = 0; i < Size; i++)
        {
            var parents = random.GetItems(individsForBreeding, 2);
            int x;
            int y;
            do
            {
                x = random.Next(0, Size);
                y = random.Next(0, Size);
            } while (Individs.Any(_ => _.X == x && _.Y == y));
            var children = new Individ(x, y);
            for (int j = 0; j < IndividFunctions.FunctionSize; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    children.Coefficients[i] = parents[0].Coefficients[i];
                }
                else
                {
                    children.Coefficients[i] = parents[1].Coefficients[i];
                }
            }

            Individs[i] = children;
        }
    }
    private void Mutation()
    {
        var random = new Random();
        for (int i = 0; i < Individs.Length; i++)
        {
            var ind = Individs[i];
            for (int j = 0; j < ind.Coefficients.Length; i++)
            {
                if (random.NextDouble() < 0.1)
                {
                    ind.Coefficients[j] += random.NextDouble() - 0.5;
                }
            }
        }
    }


}
