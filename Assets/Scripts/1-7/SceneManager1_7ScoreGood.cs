using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1_7ScoreGood : SceneBase
{
    public GameObject phew;
    public Sprite phew2;

    bool point1;

    public GameObject sky_back;
    public GameObject sky_str;

    bool point2;

    float time;

    void Start()
    {
        phew.SetActive(false);
        FadeIn(phew);
        time = 0;
        point1 = true;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time > 2f)
        {
            phew.GetComponent<SpriteRenderer>().sprite = phew2;
        }

        if (time > 4f&& point1)
        {
            point1 = false;
            point2 = true;
            FadeOut(phew);
        }

        if(time > 6f && time < 12f)
        {
            FadeIn(sky_back);
        }

        if (time > 8f && time < 12f)
        {
            FadeIn(sky_str);
        }

        if (time > 12f && point2)
        {
            point2 = false;
            FadeOut(sky_back);
            FadeOut(sky_str);
        }
        if (time > 14f)
        {
            SceneManager.LoadScene("Chapter1Score");
        }
    }
}
