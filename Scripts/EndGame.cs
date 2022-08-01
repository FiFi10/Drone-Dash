using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    private int goal;
    private int c;
    private float t;
    public int score;

    void OnTriggerEnter(Collider ent)
    {
        if(ent.transform.tag == "EndGame")
        {
            goal = GameObject.Find("Left Spawn").GetComponent<Goal>().score;
            t = GameObject.Find("TimerObj").GetComponent<TimerScript>().timer;
            c = GameObject.Find("ThirdPersonController").GetComponent<Coins>().noOfCoins;
            score = ((int)t * 2) + (c * 5) + goal;
            PlayerPrefs.SetInt("score",score);
            //PlayerPrefs.Save();
            //Debug.Log(score);
            SceneManager.LoadScene("Menu");
        }
    }
}
