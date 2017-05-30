using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollision : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "RedPortal" && collision.gameObject.tag == "Player1")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "RedSwitch" && collision.gameObject.tag == "Player1")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "RedPortalSwitch" && collision.gameObject.tag == "Player1")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "YellowPortal" && collision.gameObject.tag == "Player2")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "YellowSwitch" && collision.gameObject.tag == "Player2")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "YellowPortalSwitch" && collision.gameObject.tag == "Player2")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "GreenPortal" && collision.gameObject.tag == "Player3")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "GreenSwitch" && collision.gameObject.tag == "Player3")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "GreenPortalSwitch" && collision.gameObject.tag == "Player3")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "BluePortal" && collision.gameObject.tag == "Player4")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "BlueSwitch" && collision.gameObject.tag == "Player4")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "BluePortalSwitch" && collision.gameObject.tag == "Player4")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        /* Destroys the Orange Portal if anyone has the key
        if (gameObject.GetComponent<PlayerController>().hasKey == true && collision.gameObject.tag == "OrangePortal")
        {
            Destroy(collision.gameObject);
        }*/
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.tag == "OrangePortal" && collision.gameObject.tag == "OrangeSlime")
        {
            collision.gameObject.layer = 11;
        }
        else if (gameObject.tag == "OrangePortal" && collision.gameObject.tag == "OrangeSlime2")
        {
            collision.gameObject.layer = 11;
        }

        if (gameObject.tag == "CyanPortal" && collision.gameObject.tag == "CyanSlime")
        {
            collision.gameObject.layer = 11;
        }
        else if (gameObject.tag == "CyanPortal" && collision.gameObject.tag == "CyanSlime2")
        {
            collision.gameObject.layer = 11;
        }

        /* void OnCollisionStay2D(Collision2D collision)
        {
            if (gameObject.tag == "RedPortal" && collision.gameObject.tag == "Player1")
            {
                Debug.Log("Entering");
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

            if (gameObject.tag == "YellowPortal" && collision.gameObject.tag == "Player2")
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

            if (gameObject.tag == "GreenPortal" && collision.gameObject.tag == "Player3")
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

            if (gameObject.tag == "BluePortal" && collision.gameObject.tag == "Player4")
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

           /* if (gameObject.tag == "OrangePortal" && collision.gameObject.tag == "OrangeSlime" || collision.gameObject.tag == "OrangeSlime2")
            {
                collision.gameObject.layer = 11;
                //Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }

            if (gameObject.tag == "OrangePortal" && collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
            }

            // Destroys the Orange Portal if anyone has the key
            if (gameObject.GetComponent<PlayerController>().hasKey == true && collision.gameObject.tag == "OrangePortal")
            {
                Destroy(collision.gameObject);
            }
    }*/

    }
}

