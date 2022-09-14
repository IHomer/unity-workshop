using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Treasure : MonoBehaviour
{
    [SerializeField] private UnityEvent onOpen;
    
    public void TryOpen(DeelnemerInventory deelnemerInventory)
    {
        if (deelnemerInventory.HasKey)
        {
            Open();
        }
    }

    private void Open()
    {
        onOpen?.Invoke();
        Destroy(gameObject);
    }
}
