using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float x, y,speed;
    public GameObject player;
    public Rigidbody2D rb;
    public bool grounded,jumped;
    public Animator animator;
    public bool move;
    public int muki;
    public int motion;
    public float jumpstatus;

    public float jumptime=0;
    public bool pad;
    void isGrounded()
    {

    }

    void jump()
    {
        if(jumped == false)
        {
            rb.AddForce(Vector2.up * jumpstatus);
        }
        jumped = true;
        
       
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        speed = 3;
        player = this.gameObject;
        rb = player.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        jumpstatus = 350f;

        if (pad)
        {
            jumpstatus = 650f;
        }

        x = player.transform.position.x;
        y = player.transform.position.y;
        move = false;
        //animator.SetBool("move",false);

        if(jumped == true)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

        if (Input.GetKey("d"))
        {
            if(jumped == false)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                move = true;
                muki = 1;
            }
            
        }
        else if (Input.GetKey("a"))
        {
            if(jumped == false)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                move = true;
                muki = -1;
            }
            
        }
        else
        {
            if(jumped == false)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
                //animator.SetBool("move", true);
            }
            
        }


        if (Input.GetKey("w"))
        {
            if(jumptime > 0.1f)
            {
                jump();
            }
            jumptime = 0;
            //move = true;
            //animator.SetBool("move", true);
        }

        if (jumped)
        {
            motion = 3;
        }else if(move){
            motion = 2;
        }else
        {
            motion = 1;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            
            pad = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("a");
        if (collision.gameObject.tag == "ground")
        {
            jumped = false;
            jumptime += Time.deltaTime;

        }

        if (collision.gameObject.tag == "jumpPad")
        {
            jumped = false;
            jumptime += Time.deltaTime;
            pad = true;

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jumpPad")
        {

            jumped = false;
            jumptime += Time.deltaTime;
            pad = true;
        }
    }
}
