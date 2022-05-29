using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Serializable]
    public struct Struct
    {
        public GameObject obj;
        public int mid;
        public bool high;
    }

    public GameObject mid1, mid2, mid3, mid4;
    [SerializeField]
    Struct target1,target2,target3;


    void Start()
    {
        if(target1.mid == 1)
        {
            target1.obj.transform.parent = mid1.transform;
        }
        if (target1.mid == 2)
        {
            target1.obj.transform.parent = mid2.transform;
        }
        if (target1.mid == 3)
        {
            target1.obj.transform.parent = mid3.transform;
        }
        if (target1.mid == 4)
        {
            target1.obj.transform.parent = mid4.transform;
        }


        if (target2.mid == 1)
        {
            target2.obj.transform.parent = mid1.transform;
        }
        if (target2.mid == 2)
        {
            target2.obj.transform.parent = mid2.transform;
        }
        if (target2.mid == 3)
        {
            target2.obj.transform.parent = mid3.transform;
        }
        if (target2.mid == 4)
        {
            target2.obj.transform.parent = mid4.transform;
        }


        if (target3.mid == 1)
        {
            target3.obj.transform.parent = mid1.transform;
        }
        if (target3.mid == 2)
        {
            target3.obj.transform.parent = mid2.transform;
        }
        if (target3.mid == 3)
        {
            target3.obj.transform.parent = mid3.transform;
        }
        if (target3.mid == 4)
        {
            target3.obj.transform.parent = mid4.transform;
        }

        if(target1.high == true)
        {
            target1.obj.transform.localPosition = new Vector3(0.15f,0,0.8f);
        }
        if (target1.high == false)
        {
            target1.obj.transform.localPosition = new Vector3(0.15f, 0, 0.5f);
        }
        if (target2.high == true)
        {
            target2.obj.transform.localPosition = new Vector3(0.15f, 0, 0.8f);
        }
        if (target2.high == false)
        {
            target2.obj.transform.localPosition = new Vector3(0.15f, 0, 0.5f);
        }
        if (target3.high == true)
        {
            target3.obj.transform.localPosition = new Vector3(0.15f, 0, 0.8f);
        }
        if (target3.high == false)
        {
            target3.obj.transform.localPosition = new Vector3(0.15f, 0, 0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
