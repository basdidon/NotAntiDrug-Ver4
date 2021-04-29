using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform[] TeleportEndPoint;

    private void Update()
    {
        //Debug.Log((int)Random.Range(0,3));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int rnd = Random.Range(0, TeleportEndPoint.Length);
            PlayerMovement.instance.transform.position = TeleportEndPoint[rnd].position;
        }
    }
}
