namespace Core.GenethicAlgorythm;

internal static class IndividFunctions
{
    public const int FunctionSize = 9;
    public static double MoveFunction(double[] coefficients, double[] x)
    {
        if (coefficients.Length != x.Length)
        {
            throw new Exception("Функция должна принимать 9 коэффициентов");
        }
        if (x.Length != 9 )
        {
            throw new Exception("Входные данные должны иметь 8 клетки вокруг организма и значение энергии");
        }
        double result = coefficients[0];
        for (int i = 1; i < x.Length; i++)
        {
            result += coefficients[i] * Math.Pow(x[i], i);
        }
        return result;
    }
}
