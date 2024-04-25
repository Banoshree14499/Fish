using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject fisho,blood,spark;
    private void Update()
    {
        if (fisho.transform.position.z >= 100 + transform.position.z)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fish"))
        {
            if (fish.lives < 5)
            {
                fish.lives += 1;
            }
            blood.SetActive(false);
            spark.SetActive(false);
            Destroy(gameObject);
        }
    }
}
