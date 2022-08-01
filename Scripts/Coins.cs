using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    public int noOfCoins = 0;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider ent)
    {
        GameObject other = ent.gameObject;
        if (ent.transform.tag == "Coin")
        {
            this.GetComponent<AudioSource>().Play();
            Destroy(ent.GetComponent<Collider>().gameObject);
            noOfCoins++;
        }
        
    }

    void Update()
    {
        
    }
}