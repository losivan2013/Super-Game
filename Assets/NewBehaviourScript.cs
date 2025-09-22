using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ public float speed = 4;
  public float JumpForce = 1f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {

        float h = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Мы нажали Jump");
            rb.AddForce(new Vector2(0, JumpForce));
        }

        
        transform.Translate(h, 0, 0);  
        
    }
}
