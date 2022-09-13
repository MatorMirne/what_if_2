using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1Score : SceneBase
{
    public GameObject good, bad;

    float timer = 0;
    bool point = false;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 0.5 && SceneManage2_1.goodEnd && !point)
        {
            FadeIn(good);
            point = true;
        }
        if(timer > 2.5 && SceneManage2_1.goodEnd && point)
        {
            FadeOut(good);
            point = false;
        }

        if (timer < 0.5 && !SceneManage2_1.goodEnd && !point)
        {
            FadeIn(bad);
            point = true;
        }
        if (timer > 2.5 && !SceneManage2_1.goodEnd && point)
        {
            FadeOut(bad);
            point = false;
        }
        
        if(timer > 4)
        {
            if (SceneManage2_1.goodEnd)
            {
                SceneManager.LoadScene("2-2");
            }
            else
            {
                SceneManager.LoadScene("2-1-3");
            }
        }
    }
}
