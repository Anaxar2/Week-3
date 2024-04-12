using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalControls : MonoBehaviour
{
    public float speed = 10.0f;
    public float topBound = 30f;
    public float lowerBound = -10f;
    GameManager _gm;

    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.FindGameObjectWithTag("game manager").GetComponent<GameManager>();
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            {
                _gm.healthPoints -= 1;
                Debug.Log("Hit");
                Destroy(gameObject);
            }
            
            if (_gm.healthPoints <= 0)
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //Destroy(other.gameObject);

        }


    }
}
