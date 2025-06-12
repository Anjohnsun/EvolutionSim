namespace Core.GenethicAlgorythm;

internal class IndividWithProbability
{
    public Individ Individ { get; }
    public double Probability { get; }

    public IndividWithProbability(Individ individ, double probability)
    {
        Individ = individ;
        Probability = probability;
    }
}
