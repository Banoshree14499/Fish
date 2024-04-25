using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour {

    public GameObject Fish;
	// Update is called once per frame
	void Update () {
		if(Fish.transform.position.z>=(transform.position.z+600f))
        {
            Destroy(gameObject);
        }
	}
}
