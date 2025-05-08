using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class birdrotation : MonoBehaviour
{
    Rigidbody2D a;
    float speed = 4f;
    int score = 0;
    public Text l,b;
    int n = 0,bi=0,co=0,so=0;
    public GameObject bird, bird2;
    Animator animator;
    new AudioSource audio;
    public AudioClip clip, clip1;
    float sli = 0;
    bool isgamepause=false;
    birdrotation control;
    void Start()
    {
        a= GetComponent<Rigidbody2D>();
        n = PlayerPrefs.GetInt("n",0);
        bi = PlayerPrefs.GetInt("bi",0);
        so = PlayerPrefs.GetInt("so",0);
        sli = PlayerPrefs.GetFloat("sli",0);
        animator=GetComponent<Animator>();
        audio=GetComponent<AudioSource>();
        control = FindObjectOfType<birdrotation>();
        if(so==0)
        {
            audio.Play();
        }
        if (so == 1)
        {
            audio.volume=0;
        }
        if(bi==0)
        {
            bird2.SetActive(false);
            bird.SetActive(true);
        }
        if (bi==1)
        {
            bird.SetActive(false);
            bird2.SetActive(true);
        }

    }

    void Update()
    {
        if (control.isgamepause==false)
        {
            a.velocity = new Vector2( speed, a.velocity.y);
        }
        if (n==0)
        {
            if(control.isgamepause==false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    a.velocity = new Vector2(a.velocity.x, speed);
                }
            }
        }
        if(n==1)
        {
            btntouch();
        }
        if (transform.position.x != 0) 
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="coin")
        {
            Destroy(collision.gameObject);
            co = co + 5;
            b.text = "COIN "+co;
            audio.clip = clip;
            audio.Play();
        }
        if(collision.gameObject.tag=="pipe")
        {
            StartCoroutine(btngame());
        }
        if(collision.gameObject.tag=="score")
        {
            Destroy(collision.gameObject);
            score = score + 1;
            l.text = "score "+score;
        }
        
    }
    IEnumerator btngame()
    {
        animator.SetTrigger("isdie");
        audio.clip = clip1;
        audio.Play();
        yield return new WaitForSeconds(2f);
        bird.SetActive(false);
        bird2.SetActive(false);
        SceneManager.LoadScene("loss");

    }
    void btntouch()
    {
        if(Input.touchCount>0)
        {
            Touch t=Input.GetTouch(0);
            if(t.position.x<Screen.width)
            {
                a.velocity = new Vector2(a.velocity.x, speed);
            }
        }
    }
}
