using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC: Character
{
    public NPC(string name, string role, Vector2 startingPosition) : base (name, role, startingPosition) { }


    public float GetDistanceFrom(Position targetPosition)
    {
        return GetDistanceFrom(new Vector2(targetPosition.X, targetPosition.Y));
    }

    public float GetDistanceFrom(Vector2 targetPosition)
    {
        return Mathf.Abs(Vector2.Distance(Position , targetPosition));
    }
}
