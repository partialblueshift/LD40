using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private PlayerCharacter model;
    private GameObject playerGo;
    public Sprite playerSprite;

    private const int mvtMult = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerGo.transform.position = playerGo.transform.position - new Vector3(Time.deltaTime * mvtMult, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerGo.transform.position = playerGo.transform.position + new Vector3(Time.deltaTime * mvtMult, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerGo.transform.position = playerGo.transform.position + new Vector3(0, Time.deltaTime * mvtMult);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerGo.transform.position = playerGo.transform.position - new Vector3(0, Time.deltaTime * mvtMult);
        }
    }

    private void OnEnable()
    {
        model = new PlayerCharacter("Mike", "husband", new Position { X = 5 , Y = 5});
        playerGo = new GameObject("CharGo_" + model.Name);

        var sr = playerGo.AddComponent<SpriteRenderer>();
        sr.sprite = playerSprite;
        sr.sortingLayerName = "Characters";

        playerGo.transform.position = VectorHelper.NewVector(model.Position);
    }
}
