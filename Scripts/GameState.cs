using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    private float nextCoinSpawn;
    private float nextPileSpawn;

    [SerializeField] private GameObject CoinPile;
    [SerializeField] private GameObject CoinObject;
    [SerializeField] private float coinSpawnDelay = 10;
    [SerializeField] private float pileSpawnDelay = 90;

    public Transform[] spawnPoints;
    public Transform pileSpawn;
    

    private int randomSpawn;


    // Update is called once per frame

    void Start()
    {

    }

    void Update()
    {
        randomSpawn = Random.Range(0, spawnPoints.Length);
        if (ShouldCoinSpawn())
        {
            CoinSpawn();
        }

        if (ShouldPileSpawn())
        {
            PileSpawn();
        }
    }

    private void CoinSpawn()
    {
        nextCoinSpawn = Time.time + coinSpawnDelay;
        Instantiate(CoinObject, spawnPoints[randomSpawn].position, transform.rotation);
        
    }

    private bool ShouldCoinSpawn()
    {
        return Time.time >= nextCoinSpawn;
    }

    private void PileSpawn()
    {
        nextPileSpawn = Time.time + pileSpawnDelay;
        Instantiate(CoinPile, pileSpawn.position, transform.rotation);

    }

    private bool ShouldPileSpawn()
    {
        return Time.time >= nextPileSpawn;
    }
}
