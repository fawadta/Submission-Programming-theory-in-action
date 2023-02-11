using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 50; // Inheritance
        turnSpeed = 40; // Inheritance
    }
}
