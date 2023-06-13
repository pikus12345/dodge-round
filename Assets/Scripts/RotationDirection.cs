public enum RotationDirection
{
    Ñlockwise,
    Ñounterclockwise
}
public static class RotationDirectionUtilites 
{ 
    public static RotationDirection InvertRotationDirection(RotationDirection rotationDir)
    {
        if (rotationDir == RotationDirection.Ñlockwise)
        {
            return RotationDirection.Ñounterclockwise;
        }
        else
        {
            return RotationDirection.Ñlockwise;
        }
    }
    public static int ConvertToInt(RotationDirection rotationDir)
    {
        if (rotationDir == RotationDirection.Ñlockwise)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
