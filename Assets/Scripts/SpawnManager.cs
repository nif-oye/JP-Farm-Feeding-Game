using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnPosX = 15;
    float spawnPosZ = 20;
    float spawnDelay = 2;
    float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
        new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ),
        animalPrefabs[animalIndex].transform.rotation);
    }
}
