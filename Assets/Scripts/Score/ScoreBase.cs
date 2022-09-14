using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBase : SceneBase
{
    public GameObject content;
    public string next_scene;
    public int num_content;
    float time = 0;
    bool fadeout;

    void Start()
    {
        for (int i = 0; i < num_content; i++)
        {
            if (content.transform.GetChild(i).gameObject.active)
            {
                content.transform.GetChild(i).gameObject.SetActive(false);
            }
            fadeout = false;
        }

        for (int i = 0; i < num_content; i++)
        {
            FadeIn(content.transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time > 3f&& !fadeout)
        {
            fadeout = true;
            for (int i = 0; i < num_content; i++)
            {
                FadeOut(content.transform.GetChild(i).gameObject);
            }
        }

        if (time > 6f)
        {
            SceneManager.LoadScene(next_scene);
        }
    }
}
