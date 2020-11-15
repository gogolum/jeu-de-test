using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class charactercontroller : MonoBehaviour
{

    public Rigidbody2D rb;
    public float vitesse;
    public float sautmax;
    public float run;
    private bool ontheground = true;
  
    

    void Start()
    {
        
    }


   
    void Update()
    {
        if (Input.GetKeyDown("d"))
        { rb.velocity += new Vector2(10, 0); }

        if (Input.GetKeyUp("d"))
        { rb.velocity += new Vector2(-10, 0); }

        if (Input.GetKeyDown("q"))
        { rb.velocity += new Vector2(-10, 0); }

        if (Input.GetKeyUp("q"))
        { rb.velocity += new Vector2(10, 0); }

        

        


        if (Input.GetKeyDown("space") &&ontheground)
        {
            Jump();
        }
   
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground")) 
        {
            ontheground = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground"))
        {
            ontheground = false;
          
        }
    }

    void Jump()
    {
        rb.velocity += new Vector2(0, sautmax);
    }

     
 
}
 