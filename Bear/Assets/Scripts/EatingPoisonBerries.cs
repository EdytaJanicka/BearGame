using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EatingPoisonBerries : MonoBehaviour
{
    public GameObject buttonE;
   // public int minFood = 0;
    public AllFood currentFood;
    private bool inField = false;
    public FoodBarScript foodBar;
    public GameObject thisBerryBush;
    public Animator eating;
    public StopWalking stopWhileEating;
    public int poison = -2;
    private bool hasEaten = false;
    public GameObject foodBarColor;

    void Start()
    {
        //currentFood.currentFood = minFood;
        buttonE.SetActive(false);
        foodBar.SetMinFood(0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inField == true)
        {
            stopWhileEating.StopWalkingNow();
            eating.SetTrigger("EatRight");
            hasEaten = true;
            EatBerries(5);
        }
        if(hasEaten == true)
        {
            Poison();
            hasEaten = false;
        }
        
    }

    private void Poison()
    {
        Invoke("EatPoison", 5.0f);
        Invoke("EatPoison", 6.0f);
        Invoke("EatPoison", 7.0f);
        Invoke("EatPoison", 8.0f);
        Invoke("EatPoison", 9.0f);
        Invoke("Destroy", 10.0f);
    }

    private void EatPoison()
    {
        foodBarColor.GetComponent<RawImage>().color = new Color32(26, 148, 49, 255);
        EatBerries(poison);
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        buttonE.SetActive(true);
        inField = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        buttonE.SetActive(false);
        inField = false;
    }
    void EatBerries(int berryPoints)
    {
        currentFood.currentFood += berryPoints;

        foodBar.SetFood(currentFood.currentFood);
        
    }
    void Destroy()
    {
        Destroy(thisBerryBush);
        foodBarColor.GetComponent<RawImage>().color = new Color32(217, 162, 32, 255);
    }
}
