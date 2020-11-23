using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject Esc;
    public bool inMenu = false;
    // Start is called before the first frame update
    void Start()
    {
        Esc.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inMenu == true)
            {
                Time.timeScale = 1.0f;
                Esc.SetActive(false);
                Cursor.visible = false;
                inMenu = false;
            }
            else
            {
                Time.timeScale = 0.000000001f;
                Esc.SetActive(true);
                Cursor.visible = true;
                inMenu = true;
            }
        }
    }
}
