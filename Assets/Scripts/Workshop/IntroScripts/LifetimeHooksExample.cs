using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeHooksExample : MonoBehaviour
{
    public string test = "";
    private void Awake()
    {
        Debug.Log("Lifetime: Awake");
    }

    private void Start()
    {
        Debug.Log("Lifetime: Start");
    }

    private void OnEnable()
    {
        Debug.Log("Lifetime: OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("Lifetime: OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("Lifetime: OnDestroy");
    }

    private void OnValidate()
    {
        Debug.Log("Lifetime: OnValidate");
    }
}
