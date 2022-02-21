using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float selectedSpeed;

    bool boostEnabled;
    // Start is called before the first frame update
    void Start()
    {
        selectedSpeed = moveSpeed;
        Debug.Log("Zippy's engine is fired up and ready to ride!");

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * selectedSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void SetSpeed(float speed)
    {
        selectedSpeed = speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SetSpeed(slowSpeed);
        boostEnabled = false;
        Debug.Log("Zippy crashed!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost" && !boostEnabled)
        {
            selectedSpeed = boostSpeed;
            boostEnabled = true;
            Debug.Log("Boost speed enabled");
        }
    }
}
