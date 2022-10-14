using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentExample : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out SpriteRenderer otherSpriteRenderer))
        {
            otherSpriteRenderer.color = spriteRenderer.color;
        }
    }
}
