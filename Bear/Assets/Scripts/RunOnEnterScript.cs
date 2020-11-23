using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOnEnterHumanScript : MonoBehaviour
{
    public Animator animator;

     
    public void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("HumanRun");
    }
}
