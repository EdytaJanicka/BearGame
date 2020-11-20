using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBarScript : MonoBehaviour
{
    public Slider slider;


    public void SetMinFood(int food)
    {
        slider.minValue = food;
        slider.value = food;
    }

    public void SetFood(int food)
    {
        slider.value = food;
    }
}
