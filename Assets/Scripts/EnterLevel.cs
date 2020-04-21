using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            GameManager.instance.LoadNextScene();
            Debug.Log("Is collided");
        }
        
    }
}
