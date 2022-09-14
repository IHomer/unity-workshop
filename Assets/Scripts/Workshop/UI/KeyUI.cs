using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
    [SerializeField] private Image keyImage;
    
    public void ShowKey()
    {
        keyImage.enabled = true;
    }
    
    public void HideKey()
    {
        keyImage.enabled = false;
    }
}
