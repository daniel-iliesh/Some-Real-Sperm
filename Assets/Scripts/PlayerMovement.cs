using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed = 10f;

    private Vector3 targetPos;
    private float rotationOnY;

    void Start()
    {

    }

    void FixedUpdate()
    {

        //Moving forward
        rb.AddRelativeForce(new Vector3(0, 0, 1) * forwardSpeed * Time.deltaTime);

        targetPos = new Vector3(0, 0, 0); // Here is the rotationPointOnY

        //Rotating the player
        transform.RotateAround(targetPos, Vector3.forward, rotationOnY * Time.deltaTime);
    }

    public void RotatePlayer(float newRotationOnY)
    {
        rotationOnY = newRotationOnY;
    }
}