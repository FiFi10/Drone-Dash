using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Played : MonoBehaviour
{
    public int timesPlayed;
    public Text displayPlayed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesPlayed = PlayerPrefs.GetInt("played");
        string playedText = timesPlayed.ToString();
        displayPlayed.text = playedText;
    }
}
