using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
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
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //moves projectile forward.
       
        if (transform.position.z > topBound) // checks boundary on the z axis (forwards)
        {
            Destroy(gameObject); //Destroys projectile when goes beyond 30 on the z axis.
        }
        else if (transform.position.z < lowerBound) //checks boundary on the z axis (backwards)
        {
            Destroy(gameObject); //Destroys projectile when goes beyond -10 on the z axis.
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "animal")
        {
            _gm.score += 1;
            Debug.Log(_gm.score);
            Destroy(other.gameObject);
            Destroy(gameObject);

        }

    }
}
