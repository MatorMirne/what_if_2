using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1Score : SceneBase
{
    public GameObject good, bad;

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
                //  다음 씬으로
            }
            else
            {
                //  2-1로 돌아감
            }
        }
    }
}
