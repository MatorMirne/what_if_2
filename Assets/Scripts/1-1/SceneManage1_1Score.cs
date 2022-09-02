using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_1Score : SceneBase
{
    public GameObject good, bad;
    bool point = true;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (ManagerScript.chapter1_1repeat_num == 0)
        {
            if(timer < 2.5 && point)
            {
                FadeIn(good);
                point = false;
            }
            else if(timer > 2.5 && !point)
            {
                FadeOut(good);
                point = true;
            }
        }
        else
        {
            if (timer < 2.5 && point)
            {
                FadeIn(bad);
                point = false;
            }
            else if (timer > 2.5 && !point)
            {
                FadeOut(bad);
                point = true;
            }
        }

        if(timer > 4.5)
        {
            SceneManager.LoadScene("TimeTransDtoA");
        }
    }
}
