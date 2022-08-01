using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanPatrol : MonoBehaviour
{

    public GameObject light;
    public float speed;
    private float waitTime;
    public float startWaitTime;
    private Vector3 scaleChange;

    public Transform[] moveSpots;
    private int nextPosition = 0;
    private float t;
    private int confirmation;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        scaleChange = new Vector3(1f, 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        t = GameObject.Find("TimerObj").GetComponent<TimerScript>().timer;

        transform.position = Vector3.MoveTowards(transform.position, moveSpots[nextPosition].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[nextPosition].position) < 0.2f)
        {
            nextPosition++;
            if (nextPosition >= moveSpots.Length)
            {
                nextPosition = 1;
            }
            if (waitTime <= 0)
            {
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
        if ((int)t == 5)
        {
            confirmation = 1;
        }
        else if ((int)t != 5 & confirmation == 1)
        {

        }
    }
}