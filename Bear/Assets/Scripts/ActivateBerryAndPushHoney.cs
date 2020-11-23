using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBerryAndPushHoney : MonoBehaviour
{
    public GameObject buttonE;
    private bool inField = false;
    public GameObject thisObject;
    public Animator animator;
    private bool eaten;
    void Start()
    {
        buttonE.SetActive(false);
        thisObject.GetComponent<CircleCollider2D>().enabled = false;
        eaten = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inField == true)
        {
            animator.SetTrigger("Fall");
            thisObject.GetComponent<CircleCollider2D>().enabled = true;
            eaten = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (eaten == false)
        {
            buttonE.SetActive(true);
        }
        inField = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        buttonE.SetActive(false);
        inField = false;
    }
    
}
