using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeFish : MonoBehaviour
{
    public Mesh[] fishmesh;
    public Material[] fishmat;
    public MeshFilter fish;
    public GameObject fishg,locksign;
    public int tmp;
    public static int i;
    public TextMeshProUGUI locked;

    private void Start()
    {
        i = PlayerPrefs.GetInt("Fish", 0);
    }
    public void prev()
    {
        
        if(i==0)
        {
            i = 14;
        }
        else
        {
            i = (i - 1) % 15;
            
        }
        locksign.SetActive(false);
        fish.mesh = fishmesh[i];
        fishg.GetComponent<Renderer>().material = fishmat[i];
        fishg.GetComponent<MeshCollider>().sharedMesh = fishmesh[i];
        if (i == 0)
        {
            fishg.transform.eulerAngles = new Vector3(90, 0, 0);
        }
        else if (i == 14)
        {
            fishg.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            fishg.transform.eulerAngles = new Vector3(270, 0, 0);
        }
        if (PlayerPrefs.GetInt("Highscore", 0) >= i * 250)
        {
            locksign.SetActive(false);
            PlayerPrefs.SetInt("Fish", i);
        }
        else
        {
            tmp = i * 250;
            locked.text = "Unlocks at " + tmp + " meters!";
            locksign.SetActive(true);
        }
    }

    public void next()
    {
        
        i = (i + 1) % 15;
        fish.mesh = fishmesh[i];
        fishg.GetComponent<Renderer>().material = fishmat[i];
        fishg.GetComponent<MeshCollider>().sharedMesh = fishmesh[i];
        if(i==0)
        {
            fishg.transform.eulerAngles=new Vector3(90, 0, 0);
        }
        else if(i==14)
        {
            fishg.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            fishg.transform.eulerAngles = new Vector3(270, 0, 0);
        }
        if (PlayerPrefs.GetInt("Highscore", 0) >= i * 250)
        {
            locksign.SetActive(false);
            PlayerPrefs.SetInt("Fish", i);
        }
        else
        {
            tmp = i * 250;
            locked.text = "Unlocks at " + tmp + " meters!";
            locksign.SetActive(true);
        }
    }
}
