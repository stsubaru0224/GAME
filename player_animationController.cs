using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animationController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public playerController script;
    public bool move;
    public bool jumped;
    //public int motion;
    public float x;
    void Start()
    {
        script = this.gameObject.GetComponent<playerController>();
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        move = script.move;
        jumped = script.jumped;
        //animator.SetBool("move", false);
        if (move)
        {
            animator.SetBool("move", true);
        }
        else
        {
            animator.SetBool("move", false);
        }

        //if (jumped)
        //{
            //animator.SetBool("jump",true);
        //}
        //else { animator.SetBool("jump",false); }

        if(Input.GetKey("a"))
        {
            this.transform.localScale = new Vector3(-0.4f, 0.4f,1.0f);
        }
        if(Input.GetKey("d") )
        {
            this.transform.localScale = new Vector3(0.4f, 0.4f, 1.0f);
        }
        if(this.transform.position.x == x)
        {
            //Debug.Log();
        }
        //Debug.Log(this.transform.position.x - x);

        x = this.gameObject.transform.position.x;
    }
}
