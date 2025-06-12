using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveUpAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveUp();
    }
}
