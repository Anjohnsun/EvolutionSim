using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveRightUpAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveRight();
        ind.MoveUp();
    }
}
