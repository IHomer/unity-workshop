using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deelnemer : MonoBehaviour
{
    [SerializeField] private DeelnemerMovement movement;
    
    private void Update()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var jump = Input.GetAxis("Jump");
        
        movement.Move((int)horizontalInput);
        

        if (jump > 0)
        {
            movement.Jump();
        }
    }
}
