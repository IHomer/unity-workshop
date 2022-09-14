using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 angle;
    [SerializeField] private float speed;
    
    private void Update()
    {
        transform.Rotate((speed * Time.deltaTime) * angle);
    }
}
