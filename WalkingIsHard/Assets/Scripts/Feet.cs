using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    Rigidbody2D rightFoot;
    Rigidbody2D leftFoot;

    public float speed;

    Rigidbody2D activeFoot;

    void Start()
    {
        rightFoot = GameObject.FindGameObjectWithTag("RFoot").GetComponent<Rigidbody2D>();
        leftFoot = GameObject.FindGameObjectWithTag("LFoot").GetComponent<Rigidbody2D>();
        activeFoot = rightFoot;
    }

    void Update()
    {
        DetectSpaceInput();
    }

    void FixedUpdate() {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        activeFoot.AddForce(movement * speed);
    }

    private void DetectSpaceInput() {
        if (Input.GetKeyDown("space")) {
            ChangeActiveFoot();
        }
    }

    private void ChangeActiveFoot() {
        if (activeFoot == rightFoot) {
            rightFoot.mass = 100;
            rightFoot.gravityScale = 2;
            leftFoot.mass = 1;
            leftFoot.gravityScale = 1;
            activeFoot = leftFoot;
        } else if (activeFoot == leftFoot) {
            leftFoot.mass = 100;
            leftFoot.gravityScale = 2;
            rightFoot.mass = 1;
            rightFoot.gravityScale = 1;
            activeFoot = rightFoot;
        }
    }
}
