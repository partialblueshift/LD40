using UnityEngine;
using System.Collections;

public class Furniture: WorldItem
{
    public bool Passable { get; private set; }
    public int Value { get; private set; }

    public Furniture(Position startingPosition, string name, bool passable, int value)
    {
        Position = startingPosition;
        Name = name;
        Value = value;
        Passable = passable;
    }
}
