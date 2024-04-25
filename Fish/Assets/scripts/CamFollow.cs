using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform fisht;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {

        if (fish.started == true)
        {
            transform.position = fisht.position + offset;

        }
    }
}
