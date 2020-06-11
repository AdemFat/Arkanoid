using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Movement Speed
    public float speed = 150;

    // Start is called before the first frame update
    void Start() 
    {
    }
    
    void FixedUpdate () 
    {
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");
        // Set Velocity (movement direnction * speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
   }

}


        
    

