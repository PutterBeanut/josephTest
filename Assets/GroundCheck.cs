using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    
    [HideInInspector] public bool Grounded;
    private void OnTriggerStay2D(Collider2D other)
    {
        Grounded = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Grounded = false;
    }
}
