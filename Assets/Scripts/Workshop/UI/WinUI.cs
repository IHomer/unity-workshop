using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI winText;

    public void ShowWin()
    {
        winText.enabled = true;
    }
}
