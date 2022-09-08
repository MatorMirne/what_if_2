using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1_6ScoreGood: SceneBase
{
    public GameObject content;
    float time = 0;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            FadeIn(content.transform.GetChild(i).gameObject);
        }
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > 3f)
        {
            for (int i = 0; i < 4; i++)
            {
                FadeOut(content.transform.GetChild(i).gameObject);
            }
        }

        if (time > 6f)
        {
            SceneManager.LoadScene("1-7-1");
        }
    }
}
