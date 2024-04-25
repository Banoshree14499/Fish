using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyfish : MonoBehaviour {
    public Rigidbody jelly;
    public static int jelcount = 0;
    public int jelno;
    public Transform Fish;
    public GameObject bloodshed;

    private void Start()
    {
        jelcount++;
        jelno = jelcount;
    }

    private void FixedUpdate()
    {
        if (jelno != 1)
        {
            if (Fish.transform.position.y <= (transform.position.y - 600f))
            {
                Destroy(gameObject);
            }
        }
        jelly.velocity = Vector3.up * 20;
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
            fish.lives -= 2;

            bloodshed.SetActive(true);


        }
    }
}
