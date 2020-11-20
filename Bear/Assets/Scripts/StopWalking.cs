using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalking : MonoBehaviour
{
    public GameObject Walking;
    public void StopWalkingNow()
    {
        Walking.GetComponent<BearMovement>().enabled = false;
    }
    public void StartWalkingNow()
    {
        Walking.GetComponent<BearMovement>().enabled = true;
    }
}
