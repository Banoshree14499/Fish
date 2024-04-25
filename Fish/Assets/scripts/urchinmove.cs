using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urchinmove : MonoBehaviour {

    public Rigidbody shark;
    public Transform Fish, jaw;
    bool upgoing = true, strt = false, adjusted = true, following = false;
    public float upper; public float lower;
    float followtime;
    int i = 0;
    Vector3 newpos;
    Quaternion newrot;
    public GameObject bloodshed;
    public static int urchcount = 0;
    public int sharkno;

    private void Start()
    {
        urchcount++;
        sharkno = urchcount;
        
        
    }

    private void FixedUpdate()
    {

        if (sharkno != 1)
        {
            if (Fish.transform.position.y >= (transform.position.z + 600f))
            {
                Destroy(gameObject);
            }
        }




         if (fish.started == true)
        {
            
        if (jaw.position.z >= (Fish.position.z))
        {
            shark.AddForce((Vector3.back + Vector3.up) * 20f);
        }
       }




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            /*if(following==false)
            { followtime = Time.time; }
             following = true;*/


            /*  }
             if(Time.time-followtime >= 5f)
              {*/
            Debug.Log("Eaten");
            Debug.Log("Eaten");
            fish.lives -= 1;

            bloodshed.SetActive(true);


        }
        

    }
}
