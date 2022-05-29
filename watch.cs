using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watch : MonoBehaviour
{
    public timekeep timer;
    public float time, limit;
    public float lotation;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timekeeper").GetComponent<timekeep>();
    }

    // Update is called once per frame
    void Update()
    {
        time = timer.time;
        limit = timer.timelimit;

        lotation = time / limit * 360 * (-1);

        this.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, lotation);
    }
}
