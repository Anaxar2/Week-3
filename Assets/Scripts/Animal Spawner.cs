using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animals;
    public int animalIndex;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         Instantiate(animals[animalIndex], new Vector3(0, 0, 20), animals[animalIndex].transform.rotation);
        }
    }
}
