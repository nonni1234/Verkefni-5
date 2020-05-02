using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 20f;
    private float turnSpeed = 55f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {   
        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
    }
    void FixedUpdate()
    {
        // Move the car forward from Vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the car forward from Horizontal input
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
    }
}
