using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_1Score : SceneBase
{
    public GameObject good,good_1, bad;
    bool point = true;
    float timer = 0;

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (ManagerScript.chapter1_1repeat_num == 0)
        {
            if(timer < 2.5 && point)
            {
                FadeIn(good);
                FadeIn(good_1);
                point = false;
            }
            else if(timer > 2.5 && !point)
            {
                FadeOut(good);
                FadeOut(good_1);
                point = true;
                Debug.Log("fadeout");
            }
        }

        else
        {
            if (timer < 2.5 && point)
            {
                FadeIn(bad);
                point = false;
            }
            else if (timer > 2.5 && !point)
            {
                FadeOut(bad);
                point = true;
                Debug.Log("fadeout_1");
            }
        }

        if(timer > 4.5)
        {
            SceneManager.LoadScene("1-2-1");
        }
    }
}
