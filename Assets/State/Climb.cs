using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rb.gravityScale = 0;
        //Vector3.MoveTowards
        //rb.MovePosition  
    }
}
