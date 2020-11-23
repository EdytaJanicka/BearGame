using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPrologScript : MonoBehaviour
{
    public CanvasGroup Panel1;
    public CanvasGroup Panel2;
    public CanvasGroup Panel3;
    public CanvasGroup Panel4;
    
    void Start()
    {
        StartCoroutine("Prolog");
    }

    IEnumerator Prolog()
    {
        yield return new WaitForSeconds(5);
        FadeOut();
        yield return new WaitForSeconds(10);
        FadeOut1();
        yield return new WaitForSeconds(5);
        FadeOut2();
        yield return new WaitForSeconds(7);
        FadeOut3();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Game");
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(Panel1, Panel1.alpha, 0, .5f));
    }
    public void FadeOut1()
    {
        StartCoroutine(FadeCanvasGroup(Panel2, Panel2.alpha, 0, .5f));
    }
    public void FadeOut2()
    {
        StartCoroutine(FadeCanvasGroup(Panel3, Panel3.alpha, 0, .5f));
    }
    public void FadeOut3()
    {
        StartCoroutine(FadeCanvasGroup(Panel4, Panel4.alpha, 0, .5f));
    }


    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 1)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            cg.alpha = currentValue;

            if (percentageComplete >= 1) break;

            yield return new WaitForFixedUpdate();
        }
        
    }




}
