using UnityEngine;
using UnityEngine.Events;

public class Key: MonoBehaviour
{
    [SerializeField] private UnityEvent onPickUpKey;

    public void PickUp()
    {
        onPickUpKey?.Invoke();
    }
}