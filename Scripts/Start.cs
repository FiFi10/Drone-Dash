using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public int timesPlayed;
    public void startgame()
    {
        timesPlayed = PlayerPrefs.GetInt("played");
        timesPlayed++;
        PlayerPrefs.SetInt("played", timesPlayed);

        Debug.Log("Started Game");
        SceneManager.LoadScene("SampleScene");
    }
}
