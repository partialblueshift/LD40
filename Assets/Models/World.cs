using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class World {
    private BankAccount account;
    public readonly List<NPC> Characters;
    public Tile[,] TileMap { get; private set; }

    private static World instance;

    private World()
    {
        Debug.Log("World created");

        // Create world tilemap
        TileMap = MapGenerator.GetWorldMap();

        // Initialize account
        account = new BankAccount();
        account.Add(100000);

        // Create characters
        Characters = new List<NPC> {
            new NPC("Amanda", "wife", new Vector2(11, 10)),
            new NPC("Zoe", "child", new Vector2(12, 10))
        };

        // Initialize floor plan (walls, furniture)
    }

    public static World Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new World();
            }
            return instance;
        }
    }
}
