using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private ParticleSystem toParticleSystem;
    
    [SerializeField] private Transform to;

    public void Teleport(Deelnemer deelnemer)
    {
        deelnemer.transform.position = to.position;
        toParticleSystem.Play();
    }
}
