using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public Position Position { get; private set; }
    public TileType TileType { get; private set; }

    public Tile(int x, int y, TileType tileType = TileType.Garden)
    {
        Position = new Position { X = x, Y = y };
        TileType = tileType;
    }

}

public enum TileType { Garden, Wall, Door, Tree, Floor, Patio, Path }


