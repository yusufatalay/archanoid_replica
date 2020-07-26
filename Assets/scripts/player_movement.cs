using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    //[SerializeField] private Rigidbody2D player_rb;

    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
      //  player_rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector2.right * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}