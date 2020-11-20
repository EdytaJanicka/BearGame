using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSetTrigger : MonoBehaviour
{
    public GameObject pressKey;
    public Animator bear;
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            pressKey.SetActive(false);
            bear.SetTrigger("GetUp");
        }
        
    }
}
