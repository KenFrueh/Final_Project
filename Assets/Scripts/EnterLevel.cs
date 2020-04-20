using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        //Load next level if enter trigger
        if (other.gameObject.tag == "Player")
        {
            GameManager.instance.LoadNextScene();
        }
    }
}
