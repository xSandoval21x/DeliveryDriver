using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Zippy crashed!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Zippy passed through the checkpoint!");
    }
}
