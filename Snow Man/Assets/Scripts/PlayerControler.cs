using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f; 
    Rigidbody2D rd2d;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rd2d.AddTorque(torqueAmount);
        }
    }
}
