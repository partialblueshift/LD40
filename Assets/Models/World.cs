using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {
    private const int height = 30;
    private const int width = 30;

    private BankAccount account;
    private Tile[,] tileMap;

    public World()
    {
        Debug.Log("World created");

        // Initialize account
        account = new BankAccount();
        account.Add(100000);

        // Create world tilemap
        tileMap = MapGenerator.GetWorldMap();

        for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
                tileMap[i, j] = new Tile(i, j);

        // Create characters
        Character husband = new Character("Mike", new Position { X = 10, Y = 10 });
        Character wife = new Character("Amanda", new Position { X = 11, Y = 10 });
        Character kid = new Character("Zoe", new Position { X = 12, Y = 10 });

        // Initialize floor plan (walls, furniture)


    }

}
