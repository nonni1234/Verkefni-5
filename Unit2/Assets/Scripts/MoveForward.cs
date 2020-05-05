using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;
    // Update is called once per frame
    void Update()
    { // Hreyfir hlutinn áfram
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
