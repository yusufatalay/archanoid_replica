using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class berna_script : MonoBehaviour
{
    public int bernas;

    private void OnCollisionEnter2D(Collision2D other)
    {
        bernas--;

        //Destroy(gameObject);
    }

    void Update()
    {
        Debug.Log(bernas); 
        if (bernas == 0)
        {
               
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}