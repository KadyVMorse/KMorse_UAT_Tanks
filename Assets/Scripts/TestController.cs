﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    private TankMotor motor;
    private TankData data;

    void Start()
    {
        motor = gameObject.GetComponent<TankMotor>();
        data = gameObject.GetComponent<data>();
    }

    // Update is called once per frame
    void Update()
    {
      motor.Move(data.moveSpeed);
      motor. Rotate(data.rotateSpeed);
    }
}
