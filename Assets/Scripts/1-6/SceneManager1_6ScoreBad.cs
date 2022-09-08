using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1_6ScoreBad : SceneBase
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

    // Update is called once per frame
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
            SceneManager.LoadScene("1-6-2");
        }
    }
}
