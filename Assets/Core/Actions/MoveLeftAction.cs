using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveLeftAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveLeft();
    }
}
