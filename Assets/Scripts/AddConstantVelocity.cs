﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
}
