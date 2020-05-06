using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    private PlayerController playerControllerScript;
    private float startDelay = 2f;
    private float repeatRate = 3f;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    void SpawnObstacle() {
        if (!playerControllerScript.gameOver)
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
