using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeelnemerAnimation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private DeelnemerMovement movement;
    
    [SerializeField] private Animator animator;

    private void Awake()
    {
        movement.SetJump += SetJump;
    }

    private void Update()
    {
        if (movement == null)
        {
            return;
        }

        spriteRenderer.flipX = movement.HorizontalInput < 0 || movement.HorizontalInput == 0 && spriteRenderer.flipX;

        animator.SetInteger("Horizontal", movement.HorizontalInput);
    }

    private void SetJump(bool jumping)
    {
        animator.SetBool("Jumping", jumping);
    }

    private void OnDestroy()
    {
        movement.SetJump -= SetJump;
    }
}
