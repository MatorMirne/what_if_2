using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1_2: SceneBase
{
    public GameObject wang, bg;
    public GameObject wangSeek;

    float timer = 0;

    void Start()
    {
        wang.SetActive(false);
        bg.SetActive(false);

        FadeIn(wang);
        FadeIn(bg);
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            wang.SetActive(false);
            wangSeek.SetActive(true);
        }

        if (timer > 5)
        {
            SceneManager.LoadScene("2-1-3");
        }

    }
}
