using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject pressKey;
    public GameObject tutortial;
    public GameObject arrow;
    public Animator bear;
    public Rigidbody2D rb;
    Vector2 movement;
    public AudioSource walking;
    public AllFood eating;

     void Start()
    {
        walking = GetComponent<AudioSource>();
        tutortial.SetActive(false);
        arrow.SetActive(false);

    }
    void Update()
    {
        if (Input.anyKeyDown)
        {   pressKey.SetActive(false);
            tutortial.SetActive(true);
            arrow.SetActive(true);
            bear.SetTrigger("GetUp");   
        }
        if (eating.currentFood>=1)
        {
            tutortial.SetActive(false);
            arrow.SetActive(false);
        }


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        bear.SetFloat("Horizontal", movement.x);
        bear.SetFloat("Vertical", movement.y);
        bear.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            if(walking.isPlaying)walking.Stop();
        }
        
            if (Input.GetAxisRaw("Horizontal") > 0)
        {
            bear.SetBool("Right", true);
            bear.SetBool("Left", false);
            bear.SetBool("Up", false);
            bear.SetBool("Down", false);
            if (!walking.isPlaying) walking.Play();
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", true);
            bear.SetBool("Up", false);
            bear.SetBool("Down", false);
            if (!walking.isPlaying) walking.Play();
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", false);
            bear.SetBool("Up", true);
            bear.SetBool("Down", false);
            if (!walking.isPlaying) walking.Play();
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            bear.SetBool("Right", false);
            bear.SetBool("Left", false);
            bear.SetBool("Up", false);
            bear.SetBool("Down", true);
            if (!walking.isPlaying) walking.Play();
        }

    }   

    void FixedUpdate()
        {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    
}
