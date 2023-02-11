using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float horizontalInput;
    private float forwardInput;
    public int speed;
    public int turnSpeed;
    // Update is called once per frame
    void FixedUpdate()
    {
        // Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        Move(); // ABSTRACTION
        Rotate();   // ABSTRACTION
    }
    public virtual void Move()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    }
    public virtual void Rotate()
    {
        // Rotate the vehivcle 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
