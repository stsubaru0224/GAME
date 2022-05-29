using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class iti : MonoBehaviour
{
    string x_path;
    string y_path;
    string z_path;
    public tello script;
    public float x, y, z;
    public GameObject tracker1, tracker2,tracker3,tracker4,tracker5;
    public GameObject pad;
    int s;
    public int k = 0;
    public string[] xk, yk, zk;

    public int number = 0;
    public int number_clear = 0;
    public int[] clear = new int[3];

    public bool Clear = false;
    // Start is called before the first frame update
    void Start()
    {
        x_path = Application.dataPath + "/x.txt";
        y_path = Application.dataPath + "/y.txt";
        z_path = Application.dataPath + "/z.txt";
    }

    // Update is called once per frame
    void Update()
    {
        if (script.mid == 1)
        {
            pad = tracker1;
        }
        if (script.mid == 2)
        {
            pad = tracker2;
        }
        if(script.mid == 3)
        {
            pad = tracker3;
        }
        if(script.mid == 4)
        {
            pad = tracker4;
        }
        if (Input.GetKeyDown("0"))
        {
            s = 1;
        }
        if (s == 1)
        {
            if (k < 200)
            {
                xk[k] = script.x.ToString();
                yk[k] = script.y.ToString();
                zk[k] = script.z.ToString();
                
            }
            k++;
            Debug.Log("ok");
            if (Input.GetKeyDown("0"))
            {
                File.WriteAllLines(x_path,xk);
                File.WriteAllLines(y_path, yk);
                File.WriteAllLines(z_path, zk);
                Debug.Log("success");
            }
        }
        
        x = pad.transform.position.x-(script.y/100)-0f;
        y = pad.transform.position.y+(script.z/100);
        z = pad.transform.position.z+(script.x/100)-0.15f;
        this.transform.position = new Vector3(x,y,z);

        if(number >= 3)
        {
            if (clear[number_clear] == 1)
            {
                number_clear++;
                if (clear[number_clear] == 2)
                {
                    number_clear++;
                    if(clear[number_clear] == 3)
                    {
                        Clear = true;
                        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    }
                }
            }
        }

        if(Clear == true)
        {
            Debug.Log("CLEAR!!");
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "target1")
        {
            Destroy(other.gameObject);
            clear[number] = 1;
            number++;
        }
        if(other.tag == "target2")
        {
            Destroy(other.gameObject);
            clear[number] = 2;
            number++;
        }
        if(other.tag == "target3")
        {
            Destroy(other.gameObject);
            //other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            clear[number] = 3;
            number++;
        }
    }


}
