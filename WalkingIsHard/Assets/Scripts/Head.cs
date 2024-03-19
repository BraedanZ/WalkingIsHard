using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    Head head;
    
    public float speed;

    Rigidbody2D rb;

    void Start()
    {
        head = this;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce((Vector2.up * speed));
    }
}
