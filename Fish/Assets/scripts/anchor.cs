using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anchor : MonoBehaviour {

    public ParticleSystem sand;
    public GameObject blood;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            sand.Play();
        }
        if(collision.collider.CompareTag("Fish"))
        {
            blood.SetActive(true);
            fish.lives = 0;
            fish.eaten = true;
        }
    }
}
