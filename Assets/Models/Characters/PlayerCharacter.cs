using UnityEngine;
using System.Collections;

public sealed class PlayerCharacter: Character
{
    private static PlayerCharacter instance;

    private PlayerCharacter(string name, string role, Vector2 startingPosition) : base(name, role, startingPosition) { }

    public static PlayerCharacter Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerCharacter("Mike", "husband", new Vector2(10, 10));
            }
            return instance;
        }
    }
}
