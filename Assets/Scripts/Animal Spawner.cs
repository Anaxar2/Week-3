using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animals;
    public int animalIndex;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    public float startDelay = 2;
    public float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animals.Length);

        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation, transform);
    }

}

