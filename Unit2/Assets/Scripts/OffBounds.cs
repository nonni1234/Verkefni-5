﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;
    // Update is called once per frame
    void Update()
    { // Destroyar ef hlutur fer af skjánum
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
