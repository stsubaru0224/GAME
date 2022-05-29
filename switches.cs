using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour
{
    public bool botton_status = false;



    public GameObject botton1, botton2, wall;
    //public movewall move;
    public float time = 0;
    public float timelimit=1.0f;

    public GameObject[] walls;
    public int wallcount;

    public bool change=true;

    public int now=0;
    // Start is called before the first frame update
    void Start()
    {
        botton1 = this.gameObject.transform.GetChild(0).gameObject;
        botton2 = this.gameObject.transform.GetChild(1).gameObject;
        wall = this.transform.parent.gameObject.transform.GetChild(0).gameObject;
        wallcount = wall.transform.childCount;
        walls = new GameObject[10]; 
        for(int i = 0; i < wallcount; i++)
        {
            walls[i] = wall.transform.GetChild(i).gameObject;
        }

        //move = wall.gameObject.GetComponent<movewall>();
    }

    // Update is called once per frame
    void Update()
    {
        if (botton_status == true)
        {
            botton1.SetActive(false);
            botton2.SetActive(true);
            //move.move = true;
            time += Time.deltaTime;
            if( change )
            {
                
                time = 0;
                now++;
            }
            change=false;
            
        }
        if (botton_status == false)
        {
            botton1.SetActive(true);
            botton2.SetActive(false);
            //move.move = false;
            time = 0;
            change = true;
        }

        for (int j = 0;j<wallcount;j++)
        {
            //walls[j].SetActive(false);
            if (j != now)
            {
                walls[j].SetActive(false);
            }

            if(j == now)
            {
                walls[j].SetActive(true);
            }
        }

        if(now >= wallcount)
        {
            now = 0;
        }
    }
}

