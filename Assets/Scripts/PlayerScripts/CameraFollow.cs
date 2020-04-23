using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;


    public float offset;//Keep at 6
    // Start is called before the first frame update
    void Start()
    {//Finding player game object
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {//Getting camera position based on player position
        Vector3 temp = transform.position;
        //Equal to character X position
        temp.x = playerTransform.position.x;
        //adding offset value 
        temp.x += offset;

        transform.position = temp;
    }
}
