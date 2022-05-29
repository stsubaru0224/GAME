using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton2 : MonoBehaviour
{
    public GameObject parent;
    public botton botton;
    public float time = 0;
    public float limit = 1;
    public AudioClip a;
    public AudioSource b;
    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform.parent.gameObject;
        botton = parent.GetComponent<botton>();
        b = this.gameObject.GetComponent<AudioSource>();
        b.clip = a;
        b.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        //botton.botton_status = true;
        time += Time.deltaTime;

        if(time > limit)
        {
            botton.botton_status = false;
            time = 0;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            time = 0;
        }
        //time = 0;
        //botton.botton_status = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //time = 0;
        if(collision.gameObject.tag == "shadow")
        {
            time = 0;
        }
        //botton.botton_status = false;
    }
}
