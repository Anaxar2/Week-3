using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 thirdPersonOffset = new Vector3(0,7,-10);
    
public Vector3 birdsViewOffset;
    private Vector3 currentOffset;
    private bool isThirdPerson = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (isThirdPerson)
        {
            currentOffset = player.transform.position + thirdPersonOffset;
        }
        else
        {
            currentOffset = player.transform.position + birdsViewOffset;
        }

    if(Input.GetMouseButtonDown(1)) 
        {
            if (isThirdPerson) isThirdPerson = true;
            else isThirdPerson = false;
        }
        transform.position = player.transform.position + currentOffset;
    }
}
