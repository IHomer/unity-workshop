using System;
using UnityEngine;
using UnityEngine.Events;

public class Key: MonoBehaviour
{
    [SerializeField] private UnityEvent onPickUpKey;

    public void PickUp()
    {
        onPickUpKey?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out DeelnemerInventory deelnemerInventory))
        {
            deelnemerInventory.GrabKey(this);
        }
    }
}