using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnCords = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

            Instantiate(animalPrefabs[animalIndex], spawnCords, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
