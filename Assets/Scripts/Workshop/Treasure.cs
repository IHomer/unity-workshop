using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Treasure : MonoBehaviour
{
    [SerializeField] private UnityEvent onOpen;
    [SerializeField] private Image treasureUI;

    private Coroutine showOpenFailedCoroutine;
    public void TryOpen(DeelnemerInventory deelnemerInventory)
    {
        if (deelnemerInventory.HasKey)
        {
            Open();
        }
        else
        {
            if (showOpenFailedCoroutine != null)
            {
                StopCoroutine(showOpenFailedCoroutine);
            }

            showOpenFailedCoroutine = StartCoroutine(ShowOpenFailed());
        }
    }

    private void Open()
    {
        onOpen?.Invoke();
        Destroy(gameObject);
    }

    private IEnumerator ShowOpenFailed()
    {
        treasureUI.enabled = true;
        yield return new WaitForSeconds(1);
        treasureUI.enabled = false;

        showOpenFailedCoroutine = null;
    }
}
