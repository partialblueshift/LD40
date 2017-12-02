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
            UpdateModel();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerGo.transform.position = playerGo.transform.position + new Vector3(Time.deltaTime * mvtMult, 0);
            UpdateModel();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerGo.transform.position = playerGo.transform.position + new Vector3(0, Time.deltaTime * mvtMult);
            UpdateModel();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerGo.transform.position = playerGo.transform.position - new Vector3(0, Time.deltaTime * mvtMult);
            UpdateModel();
        }
    }

    private void UpdateModel()
    {
        model.UpdatePosition(playerGo.transform.position);
    }

    void OnEnable()
    {
        model = PlayerCharacter.Instance;
        playerGo = new GameObject("CharGo_" + model.Name);

        var sr = playerGo.AddComponent<SpriteRenderer>();
        sr.sprite = playerSprite;
        sr.sortingLayerName = "Characters";

        playerGo.transform.position = model.Position;
    }
}
