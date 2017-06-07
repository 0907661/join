using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

    public string levelToLoad;

    Transform player1;
    Transform player2;
    Transform player3;
    Transform player4;

    public bool player1Ready;
    public bool player2Ready;
    public bool player3Ready;
    public bool player4Ready;

	// Use this for initialization
	void Start () {
        player1 = transform.Find("Red Plate");
        player2 = transform.Find("Yellow Plate");
        player3 = transform.Find("Green Plate");
        player4 = transform.Find("Blue Plate");

        

    }

    // Update is called once per frame
    void Update () {

        player1Ready = player1.GetComponent<PlayersReady>().player1;
        player2Ready = player2.GetComponent<PlayersReady>().player2;
        player3Ready = player3.GetComponent<PlayersReady>().player3;
        player4Ready = player4.GetComponent<PlayersReady>().player4;

        if (player1Ready == true && player2Ready == true && player3Ready == true && player4Ready == true)
        {
            Debug.Log("All players are ready!");
            SceneManager.LoadScene(levelToLoad);
        }
	}
}
