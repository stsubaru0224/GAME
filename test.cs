using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public int number = 1;
    public int[] clear = new int[3];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("hit");
        if (other.transform.tag == "tello")
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            
        }
    }

}
