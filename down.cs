using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Controller>().syori = 7;
    }
}
