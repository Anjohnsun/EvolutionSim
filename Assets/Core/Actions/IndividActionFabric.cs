namespace Core.Actions;

internal static class IndividActionFabric
{
    public static IIndividAction GetAction(double functionResult)
    {
        IIndividAction result;
        if (functionResult < 0)
            result = new MoveDownAction();
        else if (functionResult < 1)
            result = new MoveLeftDownAction();
        else if (functionResult < 2)
            result = new MoveLeftAction();
        else if (functionResult < 3)
            result = new MoveLeftUpAction();
        else if (functionResult < 4)
            result = new MoveUpAction();
        else if (functionResult < 5)
            result = new MoveRightUpAction();
        else if (functionResult < 6)
            result = new MoveRightAction();
        else
            result = new MoveRightDownAction();

        return result;
    }
}
