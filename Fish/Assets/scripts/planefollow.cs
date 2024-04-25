using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planefollow : MonoBehaviour {

    public Transform Fish;
    Vector3 newpos;

    private void FixedUpdate()
    {
        newpos = transform.position;
        newpos.z = Fish.position.z;
        transform.position = newpos;
    }
}
