using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Listi af animals
    public GameObject[] animals;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 0.8f;

    void spawnRandomAnimal() { // Spawnar random animal á random stað
        Vector3 spawnpos = new Vector3(Random.Range(-10, 10), 0, spawnPosZ);
        int index = Random.Range(0, animals.Length);
        Instantiate(animals[index], spawnpos, animals[index].transform.rotation);
    }
    private void Start()
    {
        // Spawnar animals á random interval
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);
    }
}
