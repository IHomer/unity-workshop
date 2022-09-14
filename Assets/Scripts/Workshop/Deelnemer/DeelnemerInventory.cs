using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeelnemerInventory : MonoBehaviour
{
    private Key _key;

    public bool HasKey => _key != null;

    public void GrabKey(Key key)
    {
        _key = key;
        _key.gameObject.SetActive(false);
        _key.PickUp();
    }
}