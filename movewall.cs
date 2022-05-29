using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewall : MonoBehaviour
{
    public bool move;
    public float speed = 0.2f;
    public Vector3 start;
    public float timelimit;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //time += Time.deltaTime;

        if(time > timelimit)
        {
            this.transform.position = start; 
        }

        if(move == true)
        {
            this.transform.position = this.transform.position + this.transform.up*speed;
            //time = 0;
        }
        if(move == false) {
            this.transform.position = start;
        }
    }
}
