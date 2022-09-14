using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_2Score : SceneBase
{
    public GameObject good, bad;

    float timer = 0;
    bool point = false;


    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer < 0.5 && PanScript.isGood && !point)
        {
            FadeIn(good);
            point = true;
        }
        if (timer > 2.5 && PanScript.isGood && point)
        {
            FadeOut(good);
            point = false;
        }

        if (timer < 0.5 && !PanScript.isGood && !point)
        {
            FadeIn(bad);
            point = true;
        }
        if (timer > 2.5 && !PanScript.isGood && point)
        {
            FadeOut(bad);
            point = false;
        }

        if (timer > 4)
        {
            if (PanScript.isGood)
            {
                SceneManager.LoadScene("2-3-1");
            }
            else
            {
                SceneManager.LoadScene("2-2");
            }
        }
    }
}
