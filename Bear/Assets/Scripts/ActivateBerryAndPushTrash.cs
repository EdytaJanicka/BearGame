using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBerryAndPushTrash : MonoBehaviour
{
    public GameObject buttonE;
    private bool inField = false;
    public GameObject thisObject;
    public Animator animator;
    private bool eaten;
    public Collider2D berry;
    void Start()
    {
        buttonE.SetActive(false);
        thisObject.GetComponent<EatingPoisonBerries>().enabled = false;
        eaten = false;
        berry.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inField == true)
        {
            animator.SetTrigger("Fall");
            thisObject.GetComponent<EatingPoisonBerries>().enabled = true;
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
        berry.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        buttonE.SetActive(false);
        inField = false;
    }
    
}
