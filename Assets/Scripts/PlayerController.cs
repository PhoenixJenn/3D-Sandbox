using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float speed = 2.0f;
    private float turnSpeed = 2.0f;
    private Rigidbody rb;

  
    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        // Time.deltaTime is needed because this is called once per frame
        //MovePlayerUpdate();
        
    }
    private void MovePlayerUpdate()
    {
        // No Physics
        // Y is vertical so we want X and z
      
        forwardInput = Input.GetAxis("Vertical");

        // when not using physics; just translating the object 
        // Question: Which way is forward? Vector3(0,0,1); z-axis? how do you know? 
        // translate is the position in Vector3 coordinates; 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //rotate right and left with Vector3.up instead of right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }


    // need to use FixedUpdate for physics
    private void FixedUpdate()
    {
        // Time.deltaTime not needed; called multiple times per fram as a fixed rate
        MovePlayerFixedUpdate();
    }

    private void MovePlayerFixedUpdate() {
        
        // Y is vertical so we want X and z

        forwardInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.forward * speed * forwardInput);
 
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * turnSpeed * horizontalInput);
       
    }
}
