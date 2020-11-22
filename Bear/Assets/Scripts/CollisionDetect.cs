using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameObject thisObject;
    
    private void OnTriggerStay2D(Collider2D col)
    {
         thisObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        thisObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
    }
}
