﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 turn = new Vector3(15, 30, 45) * Time.deltaTime;
        transform.Rotate(turn);
    }
}
