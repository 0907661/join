using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKey : MonoBehaviour {

    PlayerController player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            player.hasKey = true;
        }
    }
}
