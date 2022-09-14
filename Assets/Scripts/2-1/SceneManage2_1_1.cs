using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1_1 : SceneBase
{
    public GameObject wangTalk, suTalk;

    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            FadeIn(suTalk);
        }

        if (timer > 3)
        {
            FadeIn(wangTalk);
        }

        if (timer > 4.5)
        {
            Debug.Log("to next scene");
            SceneManager.LoadScene("chapter2");
        }
    }
}
