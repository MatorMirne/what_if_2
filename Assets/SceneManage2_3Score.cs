using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage2_3Score : SceneBase
{
    public GameObject good;

    float timer = 0;
    bool point = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
            //  ¥Ÿ¿Ω æ¿¿∏∑Œ
        }
    }
}
