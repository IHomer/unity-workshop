using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateExample : MonoBehaviour
{
    public float speed = 1;

    private void Update()
    {
        transform.Translate(new Vector3(-speed,0,0) * Time.deltaTime);
    }
}
