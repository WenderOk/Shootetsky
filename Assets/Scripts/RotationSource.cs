﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSource : MonoBehaviour
{
    public Transform TargetPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(TargetPoint.position);
    }
}
