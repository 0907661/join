using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private Rigidbody2D myRigidbody;

    private bool playerMoving;
    public Vector2 lastMove;

    private static bool playerExists;

    public bool hasKey;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;

        if (this.gameObject.tag == "Player1" || this.gameObject.tag == "OrangeSlime")
        {

            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
               
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                //transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }

            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
            anim.SetBool("PlayerMoving", playerMoving);
            anim.SetFloat("LastMoveX", lastMove.x);
            anim.SetFloat("LastMoveY", lastMove.y);

        }
        else if (this.gameObject.tag == "Player2" || this.gameObject.tag == "OrangeSlime2")
        {

            if (Input.GetAxisRaw("Horizontal2") > 0.5f || Input.GetAxisRaw("Horizontal2") < -0.5f)
            {
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal2") * moveSpeed, myRigidbody.velocity.y);
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal2"), 0f);
            }

            if (Input.GetAxisRaw("Vertical2") > 0.5f || Input.GetAxisRaw("Vertical2") < -0.5f)
            {
                //transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical2") * moveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical2"));
            }

            if (Input.GetAxisRaw("Horizontal2") < 0.5f && Input.GetAxisRaw("Horizontal2") > -0.5)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical2") < 0.5f && Input.GetAxisRaw("Vertical2") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }

            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal2"));
            anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical2"));
            anim.SetBool("PlayerMoving", playerMoving);
            anim.SetFloat("LastMoveX", lastMove.x);
            anim.SetFloat("LastMoveY", lastMove.y);

        }
        else if (this.gameObject.tag == "Player3" || this.gameObject.tag == "CyanSlime")
        {

            if (Input.GetAxisRaw("Horizontal3") > 0.5f || Input.GetAxisRaw("Horizontal3") < -0.5f)
            {
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal3") * moveSpeed, myRigidbody.velocity.y);
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal3"), 0f);
            }

            if (Input.GetAxisRaw("Vertical3") > 0.5f || Input.GetAxisRaw("Vertical3") < -0.5f)
            {
                //transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical3") * moveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical3"));
            }

            if (Input.GetAxisRaw("Horizontal3") < 0.5f && Input.GetAxisRaw("Horizontal3") > -0.5)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical3") < 0.5f && Input.GetAxisRaw("Vertical3") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }

            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal3"));
            anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical3"));
            anim.SetBool("PlayerMoving", playerMoving);
            anim.SetFloat("LastMoveX", lastMove.x);
            anim.SetFloat("LastMoveY", lastMove.y);

        }
        else if (this.gameObject.tag == "Player4" || this.gameObject.tag == "CyanSlime2")
        {

            if (Input.GetAxisRaw("Horizontal4") > 0.5f || Input.GetAxisRaw("Horizontal4") < -0.5f)
            {
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal4") * moveSpeed, myRigidbody.velocity.y);
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal4"), 0f);
            }

            if (Input.GetAxisRaw("Vertical4") > 0.5f || Input.GetAxisRaw("Vertical4") < -0.5f)
            {
                //transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical4") * moveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical4"));
            }

            if (Input.GetAxisRaw("Horizontal4") < 0.5f && Input.GetAxisRaw("Horizontal4") > -0.5)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical4") < 0.5f && Input.GetAxisRaw("Vertical4") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }

            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal4"));
            anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical4"));
            anim.SetBool("PlayerMoving", playerMoving);
            anim.SetFloat("LastMoveX", lastMove.x);
            anim.SetFloat("LastMoveY", lastMove.y);

        }
    }
}
