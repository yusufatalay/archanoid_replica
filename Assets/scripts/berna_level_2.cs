using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berna_level_2 : MonoBehaviour
{
    [SerializeField] private int health =2;
    [SerializeField] private SpriteRenderer sprnd;

    private void Start()
    {
        sprnd = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (health == 2)
        {
            sprnd.color =Color.gray;
            health--;
        }
        else if(health <2)  Destroy(gameObject);
        
    }
}
