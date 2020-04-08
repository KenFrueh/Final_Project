using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    //Getting speed and start position
    public float scrollSpeed = -5.0f;
    Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {//Move background on start
        startPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {//Moving to new location on screen
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, 20);
        transform.position = startPosition + Vector2.right * newPosition;
    }
}
