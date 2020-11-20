using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameObject thisObject;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
         thisObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        thisObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
    }
}
