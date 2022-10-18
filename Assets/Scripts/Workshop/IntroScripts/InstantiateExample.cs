using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    public GameObject particle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnParticle();
        }
    }

    private void SpawnParticle()
    {
        var go = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(go, 3f);
    }
}
