using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destroyar on trigger enter
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
