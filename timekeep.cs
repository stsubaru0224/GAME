using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timekeep : MonoBehaviour
{
    public int times;
    public float time;
    public float timelimit = 10;

    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        times++;
        if(time > timelimit)
        {
            //times++;
            scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
