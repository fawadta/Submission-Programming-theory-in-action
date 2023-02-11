using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : Vehicle
{
    private void Start()
    {
        speed = 60; // Inheritance
        turnSpeed = 40; // Inheritance
    }
    public override void Rotate()   // POLYMORPHISM
    {
        transform.Rotate((Vector3.up + Vector3.back) * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
