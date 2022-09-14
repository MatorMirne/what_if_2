using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_3Score : SceneBase
{
    public GameObject good;

    float timer = 0;
    bool point = false;




    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer < 0.5 && !point)
        {
            FadeIn(good);
            point = true;
        }
        if (timer > 2.5 && point)
        {
            FadeOut(good);
            point = false;
        }

        if (timer > 4)
        {
            SceneManager.LoadScene("2-4-1");
        }
    }
}
