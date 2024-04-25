using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public GameObject[] life;

    // Update is called once per frame
    void Update()
    {
        switch (fish.lives)
        {
            default:
                {
                    life[0].SetActive(false);
                    life[1].SetActive(false);
                    life[2].SetActive(false);
                    life[3].SetActive(false);
                    life[4].SetActive(false);
                    break;
                }
            case 1:
                {
                    life[0].SetActive(true);
                    life[1].SetActive(false);
                    life[2].SetActive(false);
                    life[3].SetActive(false);
                    life[4].SetActive(false);
                    break;
                }
            case 2:
                {
                    life[0].SetActive(true);
                    life[1].SetActive(true);
                    life[2].SetActive(false);
                    life[3].SetActive(false);
                    life[4].SetActive(false);
                    break;
                }
            case 3:
                {
                    life[0].SetActive(true);
                    life[1].SetActive(true);
                    life[2].SetActive(true);
                    life[3].SetActive(false);
                    life[4].SetActive(false);
                    break;
                }
            case 4:
                {
                    life[0].SetActive(true);
                    life[1].SetActive(true);
                    life[2].SetActive(true);
                    life[3].SetActive(true);
                    life[4].SetActive(false);
                    break;
                }
            case 5:
                {
                    life[0].SetActive(true);
                    life[1].SetActive(true);
                    life[2].SetActive(true);
                    life[3].SetActive(true);
                    life[4].SetActive(true);
                    break;
                }
        }
    }
}
