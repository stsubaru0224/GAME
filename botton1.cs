using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton1 : MonoBehaviour
{
    public GameObject parent;
    public botton botton;
    public float time, limit;
    public AudioClip a;
    public AudioSource b;
    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform.parent.gameObject;
        botton = parent.GetComponent<botton>();
        b = this.gameObject.GetComponent<AudioSource>();

        //a = "/assets/魔王魂 効果音 スイッチ01";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //botton.botton_status = true;
        time += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
           
            time = 0;
            botton.botton_status = true;
            
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "shadow")
        {
            //b.clip = a;
            //b.Play();
            time = 0;
            botton.botton_status = true;
        }
        
    }
}
