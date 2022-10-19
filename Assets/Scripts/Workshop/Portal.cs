using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private ParticleSystem toParticleSystem;
    
    [SerializeField] private Transform to;

    private void Teleport(Deelnemer deelnemer)
    {
        deelnemer.transform.position = to.position;
        toParticleSystem.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Deelnemer deelnemer))
        {
            Teleport(deelnemer);
        }
    }
}
