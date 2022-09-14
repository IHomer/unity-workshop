using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeelnemerMovement : MonoBehaviour
{
    public event Action<bool> SetJump = delegate { };

    [SerializeField] private float moveSpeed = 2;
    [SerializeField] private float jumpForce = 2;
    [SerializeField] private new Rigidbody2D rigidbody;

    [SerializeField] private LayerMask floor;


    private bool _jumping;
    public int HorizontalInput { get; private set; }
    
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * (HorizontalInput * moveSpeed * Time.fixedDeltaTime));
    }
    
    public void Move(int horizontal)
    {
        HorizontalInput = horizontal;
    }

    public void Jump()
    {
        if (_jumping) return;
        
        if (!Physics2D.Raycast(transform.position, Vector2.down, 1f, floor)) return;
        
        rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        _jumping = true;

        SetJump?.Invoke(true);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Floor"))
        {
            _jumping = false;

            SetJump?.Invoke(false);
        }
    }
}
