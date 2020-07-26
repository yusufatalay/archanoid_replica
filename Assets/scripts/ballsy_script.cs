using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsy_script : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ball_rb;

    [SerializeField] private float speed;

    private int func_counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        ball_rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(func_counter==0) directionSelector(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(func_counter ==0) directionSelector(-1);
        }
        
        
        
    }

    void directionSelector(int direction)
    {
        if (direction == 1)
        {
            Vector2 dir_vec = new Vector2(1f,Mathf.Sqrt(3));
            ball_rb.AddForce(dir_vec*speed*Time.deltaTime,ForceMode2D.Impulse);
        }
        else  
        {
            Vector2 dir_vec = new Vector2(-1f,Mathf.Sqrt(3));
            ball_rb.AddForce(dir_vec*speed*Time.deltaTime,ForceMode2D.Impulse);
        }
        func_counter++;
    }
}
