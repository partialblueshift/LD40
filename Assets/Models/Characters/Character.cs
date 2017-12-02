using UnityEngine;
using System.Collections;

public abstract class Character
{
    public string Name { get; private set; }
    public string Role { get; private set; }
    public Vector2 Position { get; private set; }

    public Character(string name, string role, Vector2 startingPosition)
    {
        Name = name;
        Role = role;
        Position = startingPosition;
    }

    public void UpdatePosition(Vector2 newPosition)
    {
        Position = newPosition;
    }
}
