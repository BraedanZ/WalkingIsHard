using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFoot : MonoBehaviour
{
    RFoot rfoot;

    public float speed;

    Rigidbody2D rb;

    void Start()
    {
        rfoot = this;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb.AddForce(movement * speed);
    }
}
