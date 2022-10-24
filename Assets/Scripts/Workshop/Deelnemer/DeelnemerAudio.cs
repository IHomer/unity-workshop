using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeelnemerAudio : MonoBehaviour
{
    [SerializeField] private DeelnemerMovement movement;
    [SerializeField] private AudioSource audioSource;  
    [SerializeField] private AudioClip audioClip;  
        
    private void Awake()
    {
        movement.SetJump += OnJump;
    }

    private void OnDestroy()
    {
        movement.SetJump -= OnJump;
    }

    private void OnJump(bool jump)
    {
        if (jump)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
