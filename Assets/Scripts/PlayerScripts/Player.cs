using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Game object variables
    private Transform tf;
    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    public bool isGrounded;
    public Transform GroundPoint;
    //Movement variables
    public float speed = 5.0f;
    public float jumpForce = 200.0f;



    // Start is called before the first frame update
    void Start()
    {//Getting variables
        tf = gameObject.GetComponent<Transform>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {//Moving the player
        float xMovement = Input.GetAxis("Horizontal") * speed;
        rb2d.velocity = new Vector2(xMovement, rb2d.velocity.y);
        if (xMovement > 0)
        {
            sr.flipX = false;
        }
        else if (xMovement < 0)
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)//Jumping 
        {
            Debug.Log("Jumping");
            rb2d.AddForce(Vector2.up * jumpForce);
        }
        //checking if player is on the ground
        RaycastHit2D hitinfo = Physics2D.Raycast(GroundPoint.position, Vector2.down, 1f);
        if (hitinfo.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
