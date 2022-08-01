using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject CoinObject;
    public Transform[] pileCoinSpawns;

    void OnTriggerStay(Collider enter)
    {
        if (enter.transform.tag == "CoinPile")
        {
            Debug.Log("Bruh");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Yooooooooooooooooooooooooo");
                Destroy(GameObject.FindWithTag("CoinPile"));
                Instantiate(CoinObject, pileCoinSpawns[0].position, transform.rotation);
                Instantiate(CoinObject, pileCoinSpawns[1].position, transform.rotation);
                Instantiate(CoinObject, pileCoinSpawns[2].position, transform.rotation);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
