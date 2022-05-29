using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadow : MonoBehaviour
{
    // Start is called before the first frame update
    public struct status
    {
        public Vector2 pos;
        public int a;

    }
    public static shadow instance;
    float[] a = new float[10000];
    int[] muki = new int[10000];
    int[] motion = new int[10000];
    status[] shadowed = new status[10000];
    public int b;
    public playerController playerController;
    public timekeep timekeep;
    public Animator animator;
    int timed;
    public int times = -1;
    //float time;
    private void Awake() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        for(int i = 0; i < 10000; i++)
        {
            shadowed[i].pos.x = -100;
            shadowed[i].pos.y = -100;
        }
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(timed == 0) { times++; }
        playerController = GameObject.Find("player").GetComponent<playerController>();
        timekeep = GameObject.Find("Timekeeper").GetComponent<timekeep>();
        this.transform.position = new Vector3(shadowed[timed].pos.x, shadowed[timed].pos.y,0);
        if(times == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color=new Color32(0,0,0,0);
        }
        if(times > 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }
        if (muki[timed] == 1)
        {
            this.transform.localScale = new Vector3(0.4f, 0.4f, 1f);
        }
        if (muki[timed] == -1)
        {
            this.transform.localScale = new Vector3(-0.4f, 0.4f, 1f);
        }
        if(motion[timed] == 1)
        {
            animator.SetBool("jump", false);
            animator.SetBool("move", false);
        }
        if (motion[timed] == 2)
        {
            animator.SetBool("move", true);
            animator.SetBool("jump", false);


        }
        if (motion[timed] == 3)
        {
            animator.SetBool("jump", true);
            animator.SetBool("move", false);
        }
        a[timed] = playerController.x;
        muki[timed] = playerController.muki;
        //motion 1:wait 2:walk 3:jump
        motion[timed] = playerController.motion;
        shadowed[timed].pos.x = playerController.x;
        shadowed[timed].pos.y = playerController.y;
        shadowed[timed].a = 0;
        //Debug.Log(shadowed[timed].pos.x);
        timed = timekeep.times;
    }
}
