using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public static class MapGenerator
{
    private const string mapFilePath = @"C:\dev\LD40\Unity\LD40\Plans\plan.csv";

    public static Tile[,] GetWorldMap()
    {
        Tile[,] worldMap;

        List<string> csvLines = new List<string>();

        using (var reader = new StreamReader(mapFilePath))
            while (!reader.EndOfStream)
                csvLines.Add(reader.ReadLine());

        worldMap = new Tile[csvLines.Count, csvLines.Count];

        for (int i = 0; i < csvLines.Count; i++)
        {
            var line = csvLines[i].Split(',');
            for (int j = 0; j < line.Length; j++)
            {
                Tile tile = new Tile(i, j, (TileType)int.Parse(line[j]));
                worldMap[i, j] = tile;
            }
        }

        return worldMap;
    }

    

}
