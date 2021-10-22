using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    
    bool right,left;
    public float speed,test;
    private Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();
    }
    
    private void Move()
    {

        right = false;
        left = false;
        if (Input.GetAxis("Mouse X")>0)
        {
            right = true;
        }
        if (Input.GetAxis("Mouse X")<0)
        {
            left= true;
        }
     
          
        if (right)
        {
            
            transform.position=Vector3.Lerp(transform.position,new Vector3(5f,transform.position.y,transform.position.z),Time.deltaTime*(speed/test));
        }
        
        if (left)
        {
            transform.position=Vector3.Lerp(transform.position,new Vector3(-5f,transform.position.y,transform.position.z),Time.deltaTime*(speed/test));
        }
        
        transform.Translate(0,0,speed*Time.deltaTime);
    }
   
}
