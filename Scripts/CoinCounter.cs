using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text coinCounter;
    private int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = GameObject.Find("ThirdPersonController").GetComponent<Coins>().noOfCoins;
        string coinText = coins.ToString();
        coinCounter.text = "Coins : " + coinText;
    }
}
