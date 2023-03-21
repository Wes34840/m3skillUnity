using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCount : MonoBehaviour
{
    private float Bounces;

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        Bounces++;
        Debug.Log(collision.collider.name);

    }
}
