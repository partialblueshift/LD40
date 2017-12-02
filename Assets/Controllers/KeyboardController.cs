using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Any other keyboard inputs than moving the player character

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.E))
        {
            // Find out if we're close to another character
            List<NPC> npcList = World.Instance.Characters;

            foreach (var npc in npcList)
            {
                var dist = npc.GetDistanceFrom(PlayerCharacter.Instance.Position);
                if (dist <= 1.5)
                {
                    Debug.Log("You can talk to " + npc.Name);
                }
            }
        }

    }
}
