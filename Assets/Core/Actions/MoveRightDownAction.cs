using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveRightDownAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveRight();
        ind.MoveDown();
    }
}
