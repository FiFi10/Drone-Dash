using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public AudioSource tickSource;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            tickSource.Play();
            score = 100;
            Destroy(collision.gameObject);
        }
    }
}
