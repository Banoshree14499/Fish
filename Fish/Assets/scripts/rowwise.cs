using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rowwise : MonoBehaviour {

    
    public GameObject re1,be1,anchor,jelly;
    Vector3 newpos;
    public float strttme;
    bool tmadj = false;
    public float rnd,rnd1,rnd2,rnd3,rnd4;
    

    private void FixedUpdate()
    {
        if (fish.started == true)
        {
            if (tmadj == false)
            {
                strttme = Time.time;
                tmadj = true;
            }
            rnd = Random.Range(2, 6);
            if (Time.time % rnd == 0f)
            {
                newpos = transform.position;
                newpos.z += 300;
                rnd4 = Random.Range(90, 200);
                newpos.y = rnd4;
                Instantiate(re1, newpos, re1.transform.rotation);
            }
            rnd1 = Random.Range(2, 10);
            if ((Time.time % rnd1 == 0f) && (Time.time - strttme > 10f))
            {
                newpos = transform.position;
                newpos.z += 120;
                newpos.y = 113.1f;
                Instantiate(be1, newpos, be1.transform.rotation);
            }
            rnd2 = Random.Range(2, 30);
            if ((Time.time % rnd2 == 0f) && (Time.time - strttme > 20f))
            {
                newpos = transform.position;
                newpos.z += 300;
                newpos.y = 400;
                Instantiate(anchor, newpos, anchor.transform.rotation);
            }
            rnd3 = Random.Range(2, 20);
            if ((Time.time % rnd3 == 0f) && (Time.time - strttme > 10f))
            {
                newpos = transform.position;
                newpos.z += 300;
                newpos.y = -20;
                Instantiate(jelly, newpos, jelly.transform.rotation);
            }
        }
    }

}
