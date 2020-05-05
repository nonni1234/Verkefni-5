using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    // Update handles input and position checks
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Keeps the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    // Fixed update handles movement
    // þetta er ekki gert í unitinu en ég geri þetta samt
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
