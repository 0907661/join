using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    //public GameObject[] gameObjects;
    public GameObject gameObjects;

    public Transform redPortal;
    public Transform redPortalSwitch;
    public Transform yellowPortal;
    public Transform yellowPortalSwitch;
    public Transform greenPortal;
    public Transform greenPortalSwitch;
    public Transform bluePortal;
    public Transform bluePortalSwitch;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player1")
        {
            SwitchRedPortal();
        }
        if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player2")
        {
            SwitchYellowPortal();
        }
        if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player3")
        {
            SwitchGreenPortal();
        }
        if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player4")
        {
            SwitchBluePortal();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        {
            if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player1")
            {
                SwitchRedBack();
            }
            if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player2")
            {
                SwitchYellowBack();
            }
            if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player3")
            {
                SwitchGreenBack();
            }
            if (gameObject.tag == "PressurePlate" && collision.gameObject.tag == "Player4")
            {
                SwitchBlueBack();
            }
        }
    }

    void SwitchRedPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchRedBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BluePortalSwitch");
            Destroy(gameObjects);
            Instantiate(redPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchYellowPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("YellowSwitch");
            Destroy(gameObjects);
            Instantiate(redPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchYellowBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedPortalSwitch");
            Destroy(gameObjects);
            Instantiate(yellowPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchGreenPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenSwitch");
            Destroy(gameObjects);
            Instantiate(yellowPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchGreenBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("YellowPortalSwitch");
            Destroy(gameObjects);
            Instantiate(greenPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchBluePortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BlueSwitch");
            Destroy(gameObjects);
            Instantiate(greenPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchBlueBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenPortalSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    /* void SwitchRedPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchRedBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BluePortalSwitch");
            Destroy(gameObjects);
            Instantiate(redPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchYellowPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("YellowSwitch");
            Destroy(gameObjects);
            Instantiate(redPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchYellowBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedPortalSwitch");
            Destroy(gameObjects);
            Instantiate(yellowPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchGreenPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenSwitch");
            Destroy(gameObjects);
            Instantiate(yellowPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchGreenBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("YellowPortalSwitch");
            Destroy(gameObjects);
            Instantiate(greenPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }

    void SwitchBluePortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BlueSwitch");
            Destroy(gameObjects);
            Instantiate(greenPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchBlueBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenPortalSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }*/
}
