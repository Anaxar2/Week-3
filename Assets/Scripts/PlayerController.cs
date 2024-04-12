using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zForwardRange = 6f;
    public float turnSpeed = 1f;
    public GameObject projectilePrefab;

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

        //rotate player
        if (horizontalInput != 0)
        {
            transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
        }

        if (transform.position.x < -xRange) // uses variable xRange for paramaters on the x axis.
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //
        }

        if (transform.position.x > xRange) //uses variable xRange for paramaters on the x axis.
        {
            transform.position = new Vector3(xRange, transform.position.y , transform.position.z);
        }

       if (transform.position.z < -zForwardRange) // uses z axis as boundary.
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zForwardRange);
        }

       if(transform.position.z > zForwardRange) // uses variable zForwardRange for paramaters going forward on the z axis
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zForwardRange);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) //uses spacebar for if statement.
        {
            Instantiate(projectilePrefab, transform.position + new Vector3(0,1,0), projectilePrefab.transform.rotation); //Launch the projectile from the player
        }

    }

}
