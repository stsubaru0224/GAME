using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public float syori;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.syori = other.gameObject.GetComponent<Controller>().syori;
        if (syori == 2)
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
