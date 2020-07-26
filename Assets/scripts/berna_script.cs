using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berna_script : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
