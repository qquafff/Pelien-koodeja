﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels_Rotate : MonoBehaviour
{

    public float rotateSpeed = 10.0f;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move < 0 || move > 0) transform.Rotate(Vector3.forward * -rotateSpeed);
    }
}