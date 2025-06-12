using Core.GenethicAlgorythm;

namespace Core.Actions;

internal class MoveRightAction : IIndividAction
{
    public  void DoAction(Individ ind)
    {
        ind.MoveRight();
    }
}
