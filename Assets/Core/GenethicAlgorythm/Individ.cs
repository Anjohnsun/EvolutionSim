using Core.Actions;

namespace Core.GenethicAlgorythm;

internal class Individ
{
    public double[] Coefficients { get; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Energy { get; private set; } // -100, 100
    public int HP { get; private set; } // 0, 100
    public int Lifetime { get; private set; }

    public Individ(int x, int y)
    {
        X = x;
        Y = y;
        Energy = 0;
        Lifetime = 0;
        HP = 100;
        Coefficients = new double[IndividFunctions.FunctionSize];
    }

    public Individ(int x, int y, double[] coefficients) : this(x, y)
    {
        Coefficients = coefficients;
    }

    public void MoveLeft()
    {
        X -= 1;
    }

    public void MoveRight()
    {
        X += 1;
    }

    public void MoveUp()
    {
        Y += 1;
    }

    public void MoveDown()
    {
        Y -= 1;
    }

    public void Tick()
    {
        HP -= 2;
        Lifetime += 1;
        if (Math.Abs(Energy) < 50)
        {
            HP += 1;
        }
    }

    public int GetFitness()
    {
        return Lifetime;
    }
}


