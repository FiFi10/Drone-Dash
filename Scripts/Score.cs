using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Text highScore;
    public Text scoreDisplay;
    private int loadScore;
    //private int highestScore;

    // Start is called before the first frame update
    void Start()
    {
        loadScore = PlayerPrefs.GetInt("score");
        //Debug.Log(loadScore);
        string scoreText = loadScore.ToString();
        //Debug.Log(scoreText);
        scoreDisplay.text = "" + scoreText;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
