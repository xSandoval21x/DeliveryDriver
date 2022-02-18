using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Zippy crashed!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package") {
            hasPackage = true;
            Debug.Log("Package picked up");
        } 
        else if(other.tag == "Customer" && hasPackage) {
            hasPackage = false;
            Debug.Log("Delivered package to the customer!");
        }
    }
}
