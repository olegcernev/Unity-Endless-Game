using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
     Vector3 movement;
      
    void Update()
    {
         float moveHorizontal = Input.GetAxisRaw("Horizontal");
    
 
         movement = new Vector3(moveHorizontal, 0f );
 
         movement = movement * speed * Time.deltaTime;
 
         transform.position += movement;


         transform.position += Vector3.up*Time.deltaTime;
    }
}
