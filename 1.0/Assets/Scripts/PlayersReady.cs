using UnityEngine;
using System.Collections;

public class PlayersReady : MonoBehaviour {

	
    //public bool playersReady;
    public bool player1 = false;
    public bool player2 = false;
    public bool player3 = false;
    public bool player4 = false;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
       

	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if (gameObject.tag == "RedPlate" && other.gameObject.name == "Player 1")
        {
            player1 = true;
		}

        if (gameObject.tag == "YellowPlate" && other.gameObject.name == "Player 2")
        {
            player2 = true;
        }

        if (gameObject.tag == "GreenPlate" && other.gameObject.name == "Player 3")
        {
            player3 = true;
        }

        if (gameObject.tag == "BluePlate" && other.gameObject.name == "Player 4")
        {
            player4 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (gameObject.tag == "RedPlate" && other.gameObject.name == "Player 1")
        {
            player1 = false;
        }

        if (gameObject.tag == "YellowPlate" && other.gameObject.name == "Player 2")
        {
            player2 = false;
        }

        if (gameObject.tag == "GreenPlate" && other.gameObject.name == "Player 3")
        {
            player3 = false;
        }

        if (gameObject.tag == "BluePlate" && other.gameObject.name == "Player 4")
        {
            player4 = false;
        }
    }
}
