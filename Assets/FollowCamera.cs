using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    //Camera position should be same as car's

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0, 0, -50);
    }
}
