using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnArea : MonoBehaviour
{
    [SerializeField] private Transform respawn;
    
    private void Respawn(Deelnemer deelnemer)
    {
        deelnemer.transform.position = respawn.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Deelnemer deelnemer))
        {
            Respawn(deelnemer);
        }
    }
}
