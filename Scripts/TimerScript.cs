using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float startTime;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time - startTime;

        string minutes = ((int)timer / 60).ToString();
        string seconds = (timer % 60).ToString("f2");

        if(timer % 60 < 10 & (int)timer / 60 < 10)
        {
            timerText.text = "Timer : 0" + minutes + ":0" + seconds;
        }
        else if(timer % 60 < 10)
        {
            timerText.text = "Timer : " + minutes + ":0" + seconds;
        }
        else if((int)timer / 60 < 10)
        {
            timerText.text = "Timer : 0" + minutes + ":" + seconds;
        }
        else 
        {
            timerText.text = "Timer : " + minutes + ":" + seconds;
        }
    }
}
