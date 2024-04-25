using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkmovement : MonoBehaviour {

    public Rigidbody shark;
    public Transform Fish,jaw;
    bool upgoing = true,strt=false,adjusted=true,following=false;
    public float upper;public float lower;
    float followtime;
    int i = 0;
    Vector3 newpos;
    Quaternion newrot;
    public GameObject bloodshed;
    public static int sharkcount = 0;
    public int sharkno;

    private void Start()
    {
        sharkcount++;
        sharkno = sharkcount;
    }

    private void FixedUpdate()
    {

        if (sharkno != 1)
        {
            if (Fish.transform.position.z >= (transform.position.z + 600f))
            {
                Destroy(gameObject);
            }
        }

        if (strt == false)
        {
            upper = transform.position.y + 2;
            lower = transform.position.y - 2;
            strt = true;
            
        }
        else
        {
            if (transform.position.y >= lower && upgoing == false)
            {
                //if (platpos.position.x == -5)
                // { changed = false; }
                shark.velocity = Vector3.down * 5f;
                i++;
                //shark.AddForce((Vector3.up + Vector3.back) * 50f, ForceMode.Force);
            }
            else
            {
                upgoing = true;
                
               
            }

            if (transform.position.y <= upper && upgoing == true)
            {

                shark.velocity = Vector3.up * 5f;
               
                //shark.AddForce((Vector3.up + Vector3.back) * 50f, ForceMode.Force);
            }
            else
            {
                upgoing = false;
                i = 0;
            }
            if(i==1)
            {
                strt = false;
            }
           
            
            
        }
        //if (following == false)
        //{
        if (fish.started == true)
      {
            shark.velocity += (Vector3.back) * 10f;

      }
       //}
      /* else
       {
            newpos = transform.position;
            newpos.y = Fish.position.y-7;
            transform.position = newpos;
            newrot = transform.rotation;
            newrot.y = 0;
            transform.rotation = newrot;
            shark.velocity = Vector3.zero;
            shark.velocity += (Vector3.forward) * 50f;
        }

    */



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fish"))
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
