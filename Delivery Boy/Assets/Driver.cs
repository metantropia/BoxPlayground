using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float speed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);

        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            Debug.Log("Boooooost!!!");
            speed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Sloow Downnn!");
        speed = slowSpeed;
    }
}
