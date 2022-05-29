using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch1 : MonoBehaviour
{
    public GameObject parent;
    public switches botton;
    public float time, limit;
    public AudioClip a;
    public AudioSource b;
    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform.parent.gameObject;
        botton = parent.GetComponent<switches>();
        b = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        botton.botton_status = false;
        time += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            //b.clip = a;
            //b.Play();
            time = 0;
            botton.botton_status = true;
            
        }
        //botton.botton_status = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shadow")
        {
            //b.clip = a;
            //b.Play();
            time = 0;
            botton.botton_status = true;
            
        }

    }
}
