using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fish : MonoBehaviour {

    private const string SceneName = "Restart";
    public Rigidbody fishes;
    public Transform fisht;
    bool upgoing = true;
    public static bool started = false,destroyed=false,upfl=false,eaten=false;
    public GameObject MagicBlast,stbtn,bub1,bub2,bub3,bub4,restartscrn,life;
    float fortime=0f;
    public static int lives = 5;
    public Mesh[] fishmesh=new Mesh[15];
    public Material[] fishmat=new Material[15];
    public MeshFilter fishmf;
    public GameObject fishg,powerup;
    public int i;
    int scorest,score,high;
    public static bool highscross=false;
    public TextMeshProUGUI scoretext,hightxt;
    Vector3 tpos;

    private void Start()
    {
        i = PlayerPrefs.GetInt("Fish", 0);
        fishmf.mesh = fishmesh[i];
        fishg.GetComponent<Renderer>().material = fishmat[i];
        fishg.GetComponent<MeshCollider>().sharedMesh = fishmesh[i];
        if (i == 0)
        {
            fishg.transform.eulerAngles = new Vector3(90, 0, 0);
        }
        else if (i == 14)
        {
            fishg.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            fishg.transform.eulerAngles = new Vector3(270, 0, 0);
        }
        scorest = (int)transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate () {
        if(lives<=0)
        {
            eaten = true;
        }
        if (eaten == false)
        {
            if (started == false && destroyed == false)
            {

                if (fisht.position.y >= 139 && upgoing == false)
                {
                    //if (platpos.position.x == -5)
                    // { changed = false; }
                    fishes.velocity = Vector3.down * 5f;
                }
                else
                {
                    upgoing = true;
                    //   platform.velocity = Vector3.zero;
                }

                if (fisht.position.y <= 141.6 && upgoing == true)
                {

                    fishes.velocity = Vector3.up * 5f;
                }
                else
                {
                    upgoing = false;
                    // platform.velocity=Vector3.zero;
                }
            }
            if (started == true && destroyed == false)
            {

                if (Input.GetMouseButtonDown(0))
                { fortime = Time.time; upfl = true; }

                if (Time.time > (fortime + 1f))
                { upfl = false; }

                if (upfl == true)
                {
                    fishes.AddForce((Vector3.up + Vector3.forward) * 50f, ForceMode.Force);
                }
                else
                {
                    fishes.velocity = (Vector3.forward + Vector3.down) * 20f;
                }

            }
        }
        else
        {
            fishes.velocity = Vector3.zero;
            if (destroyed==false)
            {
                fishes.velocity = Vector3.down * 20f;
            }
           fishes.useGravity = true;
            
        }
        if(destroyed==false)
        {
            if(Random.Range(1,500)==50)
            {
                Debug.Log("PowerUp");
                Instantiate(powerup, new Vector3(transform.position.x,Random.Range(100,400),transform.position.z+100), gameObject.transform.rotation);
            }
            score = (int) transform.position.z-scorest;
            score /= 10;
            high = PlayerPrefs.GetInt("Highscore", 0);
            if(high>=score&&highscross==false)
            {
                
                hightxt.text = "HighScore: " + high;
            }
            else
            {
                highscross = true;
                hightxt.text = "New HighScore: " + high;
            }
            if(PlayerPrefs.GetInt("Highscore",0)<score)
            {
                PlayerPrefs.SetInt("Highscore", score);
            }
        }
        scoretext.text = score.ToString() + " meters";
        if(transform.position.y>=230)
        {
            tpos = transform.position;
            tpos.y = 150;
            transform.position = tpos;
        }
    }

    public void startbutton()
    {
        i = PlayerPrefs.GetInt("Fish", 0);
        fishmf.mesh = fishmesh[i];
        fishg.GetComponent<Renderer>().material = fishmat[i];
        fishg.GetComponent<MeshCollider>().sharedMesh = fishmesh[i];
        if (i == 0)
        {
            fishg.transform.eulerAngles = new Vector3(90, 0, 0);
        }
        else if (i == 14)
        {
            fishg.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            fishg.transform.eulerAngles = new Vector3(270, 0, 0);
        }
        fishes.useGravity = true;
        started = true;
        fisht.localScale += new Vector3(-0.075f, -0.075f, -0.075f);
        stbtn.SetActive(false);
        life.SetActive(true);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            Instantiate(MagicBlast);
            MagicBlast.transform.position = transform.position;
            destroyed = true;
            bub1.SetActive(false);
            bub2.SetActive(false);
            bub3.SetActive(false);
            bub4.SetActive(false);
            //gameObject.SetActive(false);
            restartscrn.SetActive(true);
            fish.lives = 0;
            
        }
    }

}
