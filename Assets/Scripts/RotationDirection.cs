public enum RotationDirection
{
    �lockwise,
    �ounterclockwise
}
public static class RotationDirectionUtilites 
{ 
    public static RotationDirection InvertRotationDirection(RotationDirection rotationDir)
    {
        if (rotationDir == RotationDirection.�lockwise)
        {
            return RotationDirection.�ounterclockwise;
        }
        else
        {
            return RotationDirection.�lockwise;
        }
    }
    public static int ConvertToInt(RotationDirection rotationDir)
    {
        if (rotationDir == RotationDirection.�lockwise)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
