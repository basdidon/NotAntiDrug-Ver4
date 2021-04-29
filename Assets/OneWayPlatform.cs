using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    public PlatformEffector2D platformEffector;
    public float surfaceArc = 170;
    public float waitTime = 0;

    void Start()
    {
        platformEffector = GetComponent<PlatformEffector2D>();
        platformEffector.surfaceArc = surfaceArc;
    }

    void Update()
    {
        if (waitTime <= 0)
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                platformEffector.surfaceArc = 0;
                waitTime = 0.5f;
            }
            
        }
        else
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                platformEffector.surfaceArc = surfaceArc;
            }
        }

        
    }
}
