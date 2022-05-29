using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CLEAR : MonoBehaviour
{
    public string nextstage;
    public Sprite nextImage;
    SpriteRenderer sr;
    GameObject shadow;
    public bool clear = false;
    public GameObject hak;
    public int times = 0;
    public int ccc;
    public AudioClip a;
    public AudioSource b;


    // Start is called before the first frame update
    void Start()
    {
        b = this.gameObject.GetComponent<AudioSource>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        shadow = GameObject.Find("shadow");
        hak = this.gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (clear)
        {
            if (times > 1)
            {
                hak.GetComponent<SpriteRenderer>().color += new Color32(0, 0, 0, 4);
                times = 0;
                ccc++;
                ccc++;
                ccc++;
                ccc++;
            }
            //hak.GetComponent<SpriteRenderer>().color += new Color32(0,0,0,1);
            times++;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            b.clip = a;
            b.Play();
            sr.sprite = nextImage;
            Destroy(shadow);

            clear = true;


            if (ccc > 256)
            {
                SceneManager.LoadScene(nextstage);
            }




        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            b.clip = a;
            b.Play();
        }

    }
}
