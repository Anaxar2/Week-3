using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zForwardRang = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //gets input (left and right) on the x axis.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // 

        verticalInput = Input.GetAxis("Vertical"); //get input (forward and backwards) on the y axis.
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime *speed);

        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y , transform.position.z);
        }

       if (transform.position.z < -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }

       if(transform.position.z > zForwardRang) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zForwardRang);
        }
    }

}
