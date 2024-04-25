using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
        public void restart()
        {
        fish.started = false;
        fish.destroyed = false; fish.upfl = false;
        fish.eaten = false;
        fish.lives = 5;
        jellyfish.jelcount = 0;
        sharkmovement.sharkcount = 0;
        urchinmove.urchcount = 0;
        fish.highscross = false;
        ChangeFish.i = PlayerPrefs.GetInt("Fish", 0);
        SceneManager.LoadScene(0);
        }
    
}
