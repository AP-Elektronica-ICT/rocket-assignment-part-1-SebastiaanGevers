﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove2 : MonoBehaviour
{
    public float flightForce;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -0.3f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 0.3f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Accelerate();
        }
    }

    private void Accelerate()
    {
        rb.AddForce(transform.up * flightForce, ForceMode.Acceleration);
    }
}
