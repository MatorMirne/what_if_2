using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_2Score : SceneBase
{
    //  하나 이상 실패했을 경우의 수 7개
    public GameObject wang, good, badMultiplug, badWindow, badElec;
    bool point = true;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (SceneManage1_2_1.elec_clear && SceneManage1_2_1.multiplug_clear && SceneManage1_2_1.window_clear)
        {
            //  good
            success(good);
        }
        else if(SceneManage1_2_1.elec_clear && SceneManage1_2_1.multiplug_clear && !SceneManage1_2_1.window_clear)
        {
            //  window fail
            fail1(badWindow);
        }
        else if(SceneManage1_2_1.elec_clear && !SceneManage1_2_1.multiplug_clear && SceneManage1_2_1.window_clear)
        {
            //  multiplug fail
            fail1(badMultiplug);
        }
        else if(!SceneManage1_2_1.elec_clear && SceneManage1_2_1.multiplug_clear && SceneManage1_2_1.window_clear)
        {
            //  elec fail
            fail1(badElec);
        }
        else if (!SceneManage1_2_1.elec_clear && !SceneManage1_2_1.multiplug_clear && SceneManage1_2_1.window_clear)
        {
            //  elec + multiplug fail
            fail2(badElec, badMultiplug);
        }
        else if (!SceneManage1_2_1.elec_clear && SceneManage1_2_1.multiplug_clear && !SceneManage1_2_1.window_clear)
        {
            //  elec + window fail
            fail2(badElec, badWindow);
        }
        else if (SceneManage1_2_1.elec_clear && !SceneManage1_2_1.multiplug_clear && !SceneManage1_2_1.window_clear)
        {
            //  multiplug + window fail
            fail2(badMultiplug, badWindow);
        }
        else
        {
            //  all fail
            fail3(badElec, badMultiplug, badWindow);
        }

        if (timer > 4.5)
        {
            SceneManager.LoadScene("1-2-1");
        }
    }

    void success(GameObject good)
    {
        timer += Time.deltaTime;
        if (timer < 2.5 && point)
        {
            FadeIn(good);
            FadeIn(wang);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(good);
            FadeOut(wang);
            point = true;
        }
     
    }

    void fail1(GameObject bad)
    {   
        if (timer < 2.5 && point)
        {
            FadeIn(bad);
            FadeIn(wang);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(bad);
            FadeOut(wang);
            point = true;
        }
     
    }

    void fail2(GameObject bad1, GameObject bad2)
    {
        if (timer < 2.5 && point)
        {
            FadeIn(bad1);
            FadeIn(bad2);
            FadeIn(wang);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(bad1);
            FadeOut(bad2);
            FadeOut(wang);
            point = true;
        }
    }

    void fail3(GameObject bad1, GameObject bad2 ,GameObject bad3)
    {
        if (timer < 2.5 && point)
        {
            FadeIn(bad1);
            FadeIn(bad2);
            FadeIn(bad3);
            FadeIn(wang);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(bad1);
            FadeOut(bad2);
            FadeOut(bad3);
            FadeOut(wang);
            point = true;
        }
    }
}
