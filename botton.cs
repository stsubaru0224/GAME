using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton : MonoBehaviour
{
    public bool botton_status = false;



    public GameObject botton1, botton2,wall;
    public movewall move;
    public float time = 0;
    public float timelimit;
    // Start is called before the first frame update
    void Start()
    {
        botton1 = this.gameObject.transform.GetChild(0).gameObject;
        botton2 = this.gameObject.transform.GetChild(1).gameObject;
        wall = this.transform.parent.gameObject.transform.GetChild(0).gameObject;
        move = wall.gameObject.GetComponent<movewall>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        if (botton_status==true)
        {
            botton1.SetActive(false);
            botton2.SetActive(true);
            move.move = true;
        }
        if (botton_status == false)
        {
            botton1.SetActive(true);
            botton2.SetActive(false);
            move.move = false;
        }
    }
}
