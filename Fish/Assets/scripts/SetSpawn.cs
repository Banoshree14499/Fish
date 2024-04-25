using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpawn : MonoBehaviour {

    public Transform fish;
    public GameObject setg;
    bool created=false;
    Vector3 newpos;
	// Update is called once per frame
	void Update () {
        if (fish.position.z >= (transform.position.z-100f)&&created==false) 
        {

            created = true;
            newpos = transform.position;
            newpos.z += 200f;
            Instantiate(setg,newpos,transform.rotation);
            
            
        }
	}
}
