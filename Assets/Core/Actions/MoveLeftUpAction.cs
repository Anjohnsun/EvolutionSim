using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveLeftUpAction : IIndividAction
{
    public void DoAction(Individ ind)
    {
        ind.MoveLeft();
        ind.MoveUp();
    }
}
