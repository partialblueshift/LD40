using UnityEngine;
using System.Collections;

public abstract class Character
{
    public string Name { get; private set; }
    public string Role { get; private set; }
    public Position Position { get; private set; }

    public Character(string name, string role, Position startingPosition)
    {
        Name = name;
        Role = role;
        Position = startingPosition;
    }
}
