using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveDownAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveDown();
    }
}
