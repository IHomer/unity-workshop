using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class CollisionEvent : MonoBehaviour
{
    private bool _isTrigger = false;

    [SerializeField] private new Collider2D collider;
    
    [SerializeField] private UnityEvent action;

    [SerializeField] private bool deelnemerOnly;

    private void OnValidate()
    {
        collider = GetComponent<Collider2D>();
    }

    private void Awake()
    {
        _isTrigger = collider.isTrigger;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_isTrigger)
        {
            return;
        }

        Handle(other.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!_isTrigger)
        {
            return;
        }

        Handle(other.gameObject);
    }

    private void Handle(GameObject other)
    {
        if (deelnemerOnly && !other.gameObject.TryGetComponent(out Deelnemer _))
        {
            return;
        }

        action?.Invoke();
    }
}
