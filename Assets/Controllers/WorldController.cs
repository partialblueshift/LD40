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

        World = World.Instance;

        // Create world tilemap
        tileMap = MapGenerator.GetWorldMap();

        foreach (var tile in tileMap)
        {
            var tileGo = new GameObject("TileGo_" + tile.Position.X + "_" + tile.Position.Y);
            tileGo.transform.position = VectorHelper.NewVector(tile.Position);

            var sr = tileGo.AddComponent<SpriteRenderer>();
            sr.sprite = spriteList.FirstOrDefault(s => s.name == tile.TileType.ToString().ToLowerInvariant());
            sr.sortingLayerName = "Floor";

            if (tile.TileType == TileType.Wall)
            {
                //var collider = tileGo.AddComponent<Collider2D>();
                //collider.

                var boxCollider = tileGo.AddComponent<BoxCollider2D>();
            }

            // tidier in the projec hierarchy
            tileGo.transform.SetParent(tileMapParentGo.transform, true);
        }

        // Place NPC
        foreach (var character in World.Characters)
        {
            var charGo = new GameObject("CharGo_" + character.Role);
            charGo.transform.position = character.Position;
            var sr = charGo.AddComponent<SpriteRenderer>();
            sr.sprite = spriteList.FirstOrDefault(s => s.name == character.Role.ToLowerInvariant());
            sr.sortingLayerName = "Characters";
        }
        
    }
}
