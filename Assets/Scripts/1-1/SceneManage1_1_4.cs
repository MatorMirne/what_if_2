using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_1_4 : SceneBase
{
    public float timer;

    public bool point1 = true;
    public GameObject str1;

    public bool point2 = false;
    public GameObject choice1;
    public GameObject choice2;

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 1 && point1)
        {
            point1 = false;
            FadeOut(str1);
        }

        if (timer > 2)
        {
            point2 = true;
            FadeIn(choice1);
            FadeIn(choice2);
        }
    }
}
