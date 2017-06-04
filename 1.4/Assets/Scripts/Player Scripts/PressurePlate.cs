using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    //public GameObject[] gameObjects;
    public GameObject gameObjects;

    public Transform redPortal;
    public Transform redPortalSwitch;
    public Transform redPortal2;
    public Transform redPortalSwitch2;
    public Transform yellowPortal;
    public Transform yellowPortalSwitch;
    public Transform greenPortal;
    public Transform greenPortalSwitch;
    public Transform bluePortal;
    public Transform bluePortalSwitch;
    public Transform bluePortal2;
    public Transform bluePortalSwitch2;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10 && transform.parent.tag == "RedParent")
        {
            SwitchRedPortal();
        }
        if (collision.gameObject.layer == 10 && transform.parent.tag == "RedParent2")
        {
            SwitchRedPortal2();
        }
        if (collision.gameObject.layer == 10 && transform.parent.tag == "YellowParent")
        {
            SwitchYellowPortal();
        }
        if (collision.gameObject.layer == 10 && transform.parent.tag == "GreenParent")
        {
            SwitchGreenPortal();
        }
        if (collision.gameObject.layer == 10 && transform.parent.tag == "BlueParent")
        {
            SwitchBluePortal();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        {
            if (collision.gameObject.layer == 10 && transform.parent.tag == "RedParent")
            {
                SwitchRedBack();
            }
            if (collision.gameObject.layer == 10 && transform.parent.tag == "RedParent2")
            {
                SwitchRedBack2();
            }
            if (collision.gameObject.layer == 10 && transform.parent.tag == "YellowParent")
            {
                SwitchYellowBack();
            }
            if (collision.gameObject.layer == 10 && transform.parent.tag == "GreenParent")
            {
                SwitchGreenBack();
            }
            if (collision.gameObject.layer == 10 && transform.parent.tag == "BlueParent")
            {
                SwitchBlueBack();
            }
        }
    }

    // Old version of pressure plate script

    /*void OnTriggerEnter2D(Collider2D collision)
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
    }*/

    void SwitchRedPortal()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchRedPortal2()
    {
        gameObjects = GameObject.FindGameObjectWithTag("RedSwitch2");
        Destroy(gameObjects);
        Instantiate(bluePortal2, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchRedBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BluePortalSwitch");
            Destroy(gameObjects);
            Instantiate(redPortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchRedBack2()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BluePortalSwitch2");
        Destroy(gameObjects);
        Instantiate(redPortalSwitch2, gameObjects.transform.position, gameObjects.transform.rotation);
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
    void SwitchBluePortal2()
    {
        gameObjects = GameObject.FindGameObjectWithTag("BlueSwitch2");
        Destroy(gameObjects);
        Instantiate(greenPortal, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchBlueBack()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenPortalSwitch");
            Destroy(gameObjects);
            Instantiate(bluePortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }
    void SwitchBlueBack2()
    {
        gameObjects = GameObject.FindGameObjectWithTag("GreenPortalSwitch2");
        Destroy(gameObjects);
        Instantiate(bluePortalSwitch, gameObjects.transform.position, gameObjects.transform.rotation);
    }
}
