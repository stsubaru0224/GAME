using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean up,down,right,left;
    public float syori;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per 
    void Update()
    {
        //if (up.GetStateDown(HandType))
        //{
           // syori = 1;
            //this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        //}
        //if (down.GetStateDown(HandType))
        //{
           // syori = 2;
            //this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        //}
        //if (right.GetStateDown(HandType))
        //{
            //syori = 3;
            //this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        //}
        //if (left.GetStateDown(HandType))
        //{
           // syori = 4;
           // this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        //}
        if(syori == 2)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }

        if (syori == 3)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (syori == 4)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

        if (syori == 5)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }

        if (syori == 6)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (syori == 7)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
