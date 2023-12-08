using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderExample : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        // other.gameObject.GetCom
        // if (other.gameObject.TryGetComponent(out SpriteRenderer spriteRenderer))
        // {
        //     
        // }
    }
}
