using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTimeScript : MonoBehaviour
{
   
    public AllFood foodScript;
    public GameObject lostPanel;
    public GameObject winPanel;
    public StopWalking stopwalking;

    void Start()
    {
        lostPanel.SetActive(false);
        winPanel.SetActive(false);
        StartCoroutine("GameTime");
    }
    IEnumerator GameTime()
    {
        yield return new WaitForSeconds(180);
        stopwalking.StopWalkingNow();
        if (foodScript.currentFood >= 70)
        {
            winPanel.SetActive(true);

        }
        else { lostPanel.SetActive(true); }
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("EndCredits");
    }
}
