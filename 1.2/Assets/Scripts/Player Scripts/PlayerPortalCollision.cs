using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPortalCollision : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

	}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.tag == "Player1" && collision.gameObject.tag == "RedPortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "Player2" && collision.gameObject.tag == "YellowPortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "Player3" && collision.gameObject.tag == "GreenPortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "Player4" && collision.gameObject.tag == "BluePortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (gameObject.tag == "OrangeSlime" && collision.gameObject.tag == "OrangePortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (gameObject.tag == "OrangeSlime2" && collision.gameObject.tag == "OrangePortal")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            
        }

        // Destroys the Orange Portal if anyone has the key
        if (gameObject.GetComponent<PlayerController>().hasKey == true && collision.gameObject.tag == "OrangePortal")
        {
            Destroy(collision.gameObject);
        }
    }
}

