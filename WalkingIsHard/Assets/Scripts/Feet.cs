using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    Rigidbody2D rightFoot;
    Rigidbody2D leftFoot;

    public float footSpeed;

    Rigidbody2D activeFoot;

    Rigidbody2D rightKnee;
    Rigidbody2D leftKnee;

    public float kneeSpeed;

    public Rigidbody2D activeKnee;

    void Start()
    {
        rightFoot = GameObject.FindGameObjectWithTag("RFoot").GetComponent<Rigidbody2D>();
        leftFoot = GameObject.FindGameObjectWithTag("LFoot").GetComponent<Rigidbody2D>();
        activeFoot = rightFoot;

        rightKnee = GameObject.FindGameObjectWithTag("RKnee").GetComponent<Rigidbody2D>();
        leftKnee = GameObject.FindGameObjectWithTag("LKnee").GetComponent<Rigidbody2D>();
        activeKnee = rightKnee;
    }

    void Update()
    {
        DetectSpaceInput();
    }

    void FixedUpdate() {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        activeFoot.AddForce(activeFoot.transform.right * horizontalInput * footSpeed);

        float verticalInput = Input.GetAxisRaw("Vertical");
        activeKnee.AddForce(activeKnee.transform.right * verticalInput * kneeSpeed);

        // Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // activeFoot.AddForce(movement * speed);
    }

    private void DetectSpaceInput() {
        if (Input.GetKeyDown("space")) {
            ChangeActiveFoot();
        }
    }

    private void ChangeActiveFoot() {
        if (activeFoot == rightFoot) {
            // rightFoot.mass = 50;
            // rightFoot.gravityScale = 2;
            // leftFoot.mass = 1;
            // leftFoot.gravityScale = 1;
            activeFoot = leftFoot;
            activeKnee = leftKnee;
        } else if (activeFoot == leftFoot) {
            // leftFoot.mass = 50;
            // leftFoot.gravityScale = 2;
            // rightFoot.mass = 1;
            // rightFoot.gravityScale = 1;
            activeFoot = rightFoot;
            activeKnee = rightKnee;
        }
    }
}
