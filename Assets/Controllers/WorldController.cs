using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorldController : MonoBehaviour {

    public World World { get; private set; }
    private Tile[,] tileMap;
    private GameObject tileMapParentGo;

    public List<Sprite> spriteList;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        tileMapParentGo = new GameObject("TileMap");

        World = new World();

        // Create world tilemap
        tileMap = MapGenerator.GetWorldMap();

        foreach (var tile in tileMap)
        {
            var tileGo = new GameObject("TileGo_" + tile.Position.X + "_" + tile.Position.Y);
            tileGo.transform.position = new Vector2(tile.Position.X, tile.Position.Y);

            var sr = tileGo.AddComponent<SpriteRenderer>();
            sr.sprite = spriteList.FirstOrDefault(s => s.name == tile.TileType.ToString().ToLowerInvariant());

            // tidier in the projec hhierarchie
            tileGo.transform.SetParent(tileMapParentGo.transform, true);
        }

    }
}
