using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOnEnterScript : MonoBehaviour
{
    public Animator animator;

     
    public void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("StagRun");
    }
}
