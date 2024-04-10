using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalControls : MonoBehaviour
{
    public float speed = 10.0f;
    public float topBound = 30f;
    public float lowerBound = -10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
