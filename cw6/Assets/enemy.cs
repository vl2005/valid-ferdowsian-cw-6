using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmy : MonoBehaviour
{
    Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    void Move()
    {

    }
}

