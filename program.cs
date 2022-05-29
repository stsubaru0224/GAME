using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class program : MonoBehaviour
{
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = head.transform.rotation;
        this.transform.position = head.transform.position-this.transform.up*0.4f+this.transform.forward*0.4f+this.transform.right*0.1f;
        
    }
}
