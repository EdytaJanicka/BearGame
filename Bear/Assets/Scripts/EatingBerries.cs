using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EatingBerries : MonoBehaviour
{
    public GameObject buttonE;
   // public int minFood = 0;
    public AllFood currentFood;
    public bool inField = false;
    public FoodBarScript foodBar;
    public GameObject thisBerryBush;
    public Animator eating;
    public StopWalking stopWhileEating;
    public int amountOfBerries = 5;

    void Start()
    {
        //currentFood.currentFood = minFood;
        buttonE.SetActive(false);
        foodBar.SetMinFood(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inField == true)
        {
            stopWhileEating.StopWalkingNow();
            eating.SetTrigger("EatRight");
            EatBerries(amountOfBerries);
        }
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
        Destroy(thisBerryBush);
    }

}
