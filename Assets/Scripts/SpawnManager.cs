using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 25;
    private float startDelay = 2;
    private float startInterval = 1.0f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnCords = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        Instantiate(animalPrefabs[animalIndex], spawnCords, animalPrefabs[animalIndex].transform.rotation);
    }
}
