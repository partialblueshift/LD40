using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {
    private const int height = 30;
    private const int width = 30;

    private BankAccount account;
    public readonly List<Character> Characters;

    public World()
    {
        Debug.Log("World created");

        // Initialize account
        account = new BankAccount();
        account.Add(100000);

        // Create characters
        Characters = new List<Character> {
            new Character("Mike", "husband", new Position { X = 10, Y = 10 }),
            new Character("Amanda", "wife", new Position { X = 11, Y = 10 }),
            new Character("Zoe", "child", new Position { X = 12, Y = 10 })
        };

        // Initialize floor plan (walls, furniture)


    }

}
