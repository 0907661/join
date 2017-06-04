using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlendingCollision : MonoBehaviour
{

    Animator animator;
    SpriteRenderer spriteRenderer;
	public AudioSource 	soundSource;
	public AudioClip 	Sound;

    // Use this for initialization
    void Start()
    {
        animator = transform.parent.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.parent.tag == "Player1" && collision.transform.parent.tag == "Player2" || transform.parent.tag == "Player1" && collision.transform.parent.tag == "OrangeSlime2")
        {
            // Changes the tags from Player 1 and Player 2 to Orangeslime and OrangeSlime2
            transform.parent.tag = "OrangeSlime";

            collision.transform.parent.tag = "OrangeSlime2";

			soundSource.PlayOneShot(Sound);
            // Overrides the Animator Controller to the Orange Slime
            animator.runtimeAnimatorController = Resources.Load("Animations/OrangeOverride/OrangeOverride") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/OrangeOverride/OrangeOverride") as RuntimeAnimatorController;
        }

        if (transform.parent.tag == "Player3" && collision.transform.parent.tag == "Player4" || transform.parent.tag == "Player3" && collision.transform.parent.tag == "CyanSlime2")
        {
            // Changes the tags from Player 3 and Player 4 to Orangeslime and OrangeSlime2
            transform.parent.tag = "CyanSlime";

            collision.transform.parent.tag = "CyanSlime2";

			soundSource.PlayOneShot(Sound);
            // Overrides the Animator Controller to the Cyan Slime
            animator.runtimeAnimatorController = Resources.Load("Animations/CyanOverride/CyanOverride") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/CyanOverride/CyanOverride") as RuntimeAnimatorController;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (transform.parent.tag == "OrangeSlime" && collision.transform.parent.tag == "OrangeSlime2")
        {
            // Changes the tags from back
            transform.parent.tag = "Player1";
            transform.parent.gameObject.layer = 10;

            collision.transform.parent.tag = "Player2";
            collision.transform.parent.gameObject.layer = 10;

            // Overrides the Animator Controller again
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 1/Player1") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/Player 2/Player2") as RuntimeAnimatorController;
        }
        else if(transform.parent.tag == "OrangeSlime2" && collision.transform.parent.tag == "OrangeSlime")
        {
            // Changes the tags from back
            transform.parent.tag = "Player2";
            transform.parent.gameObject.layer = 10;

            collision.transform.parent.tag = "Player1";
            collision.transform.parent.gameObject.layer = 10;

            // Overrides the Animator Controller again
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 2/Player2") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/Player 1/Player1") as RuntimeAnimatorController;
        }

        if (transform.parent.tag == "CyanSlime" && collision.transform.parent.tag == "CyanSlime2")
        {
            // Changes the tags from back
            transform.parent.tag = "Player3";
            transform.parent.gameObject.layer = 10;

            collision.transform.parent.tag = "Player4";
            collision.transform.parent.gameObject.layer = 10;

            // Overrides the Animator Controller again
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 3/Player3") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/Player 4/Player4") as RuntimeAnimatorController;
        }
        else if (transform.parent.tag == "CyanSlime2" && collision.transform.parent.tag == "CyanSlime")
        {
            // Changes the tags back
            transform.parent.tag = "Player4";
            transform.parent.gameObject.layer = 10;

            collision.transform.parent.tag = "Player3";
            collision.transform.parent.gameObject.layer = 10;

            // Overrides the Animator Controller again
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 4/Player4") as RuntimeAnimatorController;
            collision.transform.parent.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/Player 3/Player3") as RuntimeAnimatorController;
        }
    }

    /*
     * if (gameObject.tag == "Player1" && collision.gameObject.tag == "Player2")
        {
            // Changes the tags from Player 1 and Player 2 to Orangeslime and OrangeSlime2
            gameObject.tag = "OrangeSlime";
            collision.gameObject.tag = "OrangeSlime2";

            Debug.Log("Entering");

            // Overrides the Animator Controller to the Orange Slime
            animator.runtimeAnimatorController = Resources.Load("Animations/OrangeOverride/OrangeOverride") as RuntimeAnimatorController;
            collision.gameObject.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animations/OrangeOverride/OrangeOverride") as RuntimeAnimatorController;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == "OrangeSlime")
        {
            gameObject.tag = "Player1";
            Debug.Log("Exiting");
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 1/Player1") as RuntimeAnimatorController;
        } else if (gameObject.tag == "OrangeSlime2")
        {
            gameObject.tag = "Player2";
            Debug.Log("Exiting");
            animator.runtimeAnimatorController = Resources.Load("Animations/Player 2/Player2") as RuntimeAnimatorController;
        }
    }
    */

}
   
