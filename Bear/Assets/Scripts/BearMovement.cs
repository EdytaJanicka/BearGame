using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject pressKey;
    public Animator bear;
    public Rigidbody2D rb;
    Vector2 movement;
    public Collider2D slim;
    public Collider2D chonky;


    void Update()
    {
        if (Input.anyKeyDown)
        {   pressKey.SetActive(false);
            bear.SetTrigger("GetUp");   
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        bear.SetFloat("Horizontal", movement.x);
        bear.SetFloat("Vertical", movement.y);
        bear.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            bear.SetBool("Right", true);
            bear.SetBool("Left", false);
            bear.SetBool("Up", false);
            bear.SetBool("Down", false);
            slim.enabled = false;
            chonky.enabled = true;
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", true);
            bear.SetBool("Up", false);
            bear.SetBool("Down", false);
            slim.enabled = false;
            chonky.enabled = true;
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", false);
            bear.SetBool("Up", true);
            bear.SetBool("Down", false);
            slim.enabled = true;
            chonky.enabled = false;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", false);
            bear.SetBool("Up", false);
            bear.SetBool("Down", true);
            slim.enabled = true;
            chonky.enabled = false;
        }

    }   

    void FixedUpdate()
        {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    
}
