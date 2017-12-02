using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {
    public string Name { get; private set; }
    public Position Position { get; private set; }

    public Character(string name, Position startingPosition)
    {
        Name = name;
        Position = startingPosition;
    }
}
