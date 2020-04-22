using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    //Leaving the player area and destroying attached object
    void OnTriggerExit2D(Collider2D Other)
    {
        Destroy(Other.gameObject);
        Debug.Log("Object has been destroyed");
    }

}
