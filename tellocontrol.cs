using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using Valve.VR;

public class tellocontrol : MonoBehaviour
{
    public tello tello;
    //public inputsyori input;
    public change[] I;
    public float[] a;


    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean start;

    // Start is called before the first frame update
    public void Onclick()
    {
        tello.takeoff();
        Debug.Log("OK");
        //wait();
        //Thread.Sleep(5000);
        //yield return new WaitForSeconds(5);

        for (int i = 0; i < 5; i++)
        {
            if (a[i] == 2)
            {
                //Debug.Log("up");
                tello.left(30);
            }
            if (a[i] == 3)
            {
                //Debug.Log("down");
                tello.right(30);
            }
            if (a[i] == 4)
            {
                //Debug.Log("right");
                tello.forward(30);
            }
            if (a[i] == 5)
            {
                //Debug.Log("left");
                tello.back(30);
            }

            if (a[i] == 6)
            {
                //Debug.Log("left");
                tello.up(30);
            }

            if (a[i] == 7)
            {
               //Debug.Log("left");
                tello.down(30);
            }

            //Thread.Sleep(5000);
        }
        tello.land();
    }
    void Start()
    {
        a = new float[5];
        tello = GetComponent<tello>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            //string c = i.ToString();
            //c = "I" + c;
            a[i] = I[i].syori;


        }

        if (start.GetStateDown(HandType))
        {
            Debug.Log("sssss");
            StartCoroutine(Timer());
        }


    }
    IEnumerator Timer()
    {
        tello.takeoff();
        Debug.Log("0");
        yield return new WaitForSeconds(9);
        Debug.Log("1");
        for (int i = 0; i < 5; i++)
        {
            if (a[i] == 2)
            {
                //Debug.Log("up");
                tello.left(50);
            }
            if (a[i] == 3)
            {
                //Debug.Log("down");
                tello.right(50);
            }
            if (a[i] == 4)
            {
                //Debug.Log("right");
                tello.forward(50);
            }
            if (a[i] == 5)
            {
                //Debug.Log("left");
                tello.back(50);
            }

            if (a[i] == 6)
            {
                //Debug.Log("left");
                tello.up(50);
            }

            if (a[i] == 7)
            {
                //Debug.Log("left");
                tello.down(50);
            }
            yield return new WaitForSeconds(3);
            Debug.Log("a");
        }
        tello.land();
    }
}

    
