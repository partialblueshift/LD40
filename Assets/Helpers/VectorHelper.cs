using UnityEngine;
using System.Collections;

public static class VectorHelper
{
    public static Vector2 NewVector(Position position) { return VectorHelper.NewVector(position, 0); }
    public static Vector2 NewVector(Position position, int z) { return new Vector3(position.X, position.Y, z); }

}
