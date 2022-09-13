using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1_5Score : SceneBase
{
    public GameObject clear, hole, elec;
    public string next_scene;

    float time = 0;
    bool fadeout = false;

    private void Start()
    {
        if (ManagerScript.data_1_5 == 0)
        {
            // Clear!
            for (int i = 0; i < 4; i++)
            {
                FadeIn(clear.transform.GetChild(i).gameObject);
            }
        }
        else if (ManagerScript.data_1_5 == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                FadeIn(hole.transform.GetChild(i).gameObject);
            }
        }
        else if (ManagerScript.data_1_5 == 2)
        {
            for(int i=0; i<4; i++)
            {
                FadeIn(elec.transform.GetChild(i).gameObject);
            }
        }
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > 3f && !fadeout)
        {
            fadeout = true;
            if (ManagerScript.data_1_5 == 0)
            {
                // Clear!
                for (int i = 0; i < 4; i++)
                {
                    FadeOut(clear.transform.GetChild(i).gameObject);
                }
            }
            else if (ManagerScript.data_1_5 == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    FadeOut(hole.transform.GetChild(i).gameObject);
                }
            }
            else if (ManagerScript.data_1_5 == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    FadeOut(elec.transform.GetChild(i).gameObject);
                }
            }
        }

        if (time > 4f)
        {
            if (ManagerScript.data_1_5 == 0)
            {
                SceneManager.LoadScene(next_scene);
            }
            else if (ManagerScript.data_1_5 == 1)
            {
                ManagerScript.chapter1_score--; 
                Debug.Log("(스코어 -1) " + "현재 스코어:" + ManagerScript.chapter1_score);

                SceneManager.LoadScene("1-5-2");
            }
            else if (ManagerScript.data_1_5 == 2)
            {
                ManagerScript.chapter1_score--;
                Debug.Log("(스코어 -1) " + "현재 스코어:" + ManagerScript.chapter1_score);

                SceneManager.LoadScene("1-5-2");
            }
        }
    }
}
