using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_4Score : SceneBase
{
    public GameObject badLight, badGas, badWang, goodLight, goToWork, wangWalk;
    bool point = true;
    bool repeat = true;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (!GasScript.isOff)
        {
            ManagerScript.score--;
            if (!LightScript.isOn)
            {
                ManagerScript.score--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (GasScript.isOff && LightScript.isOn)
        {
            //  good
            repeat = false;
            success(goodLight, goToWork, wangWalk);
        }
        else if (!GasScript.isOff && LightScript.isOn)
        {
            //  bad gas
            fail2(badGas, badWang);
        }
        else if(GasScript.isOff && !LightScript.isOn)
        {
            //  bad light
            fail2(badLight, badWang);
        }
        else if(!GasScript.isOff && !LightScript.isOn)
        {
            //  both bad
            fail3(badLight, badGas, badWang);
        }

        if(repeat && timer > 4.5)
        {
            GasScript.isOff = false;
            LightScript.isOn = false;
            SceneManager.LoadScene("1-4-2");
        }
        else if(!repeat && timer > 7.5)
        {
            SceneManager.LoadScene("1-5-1");
        }
    }

    void success(GameObject good1, GameObject good2, GameObject good3)
    {
        if (timer < 2.5 && point)
        {
            FadeIn(good1);
            point = false;
        }
        else if (timer > 2.5 && timer < 4 && !point)
        {
            FadeOut(good1);
            point = true;
        }
        else if(timer > 4 && timer < 5 && point)
        {
            FadeIn(good2);
            FadeIn(good3);
            point = false;
        }
        else if(timer > 6 && !point)
        {
            FadeOut(good2);
            FadeOut(good3);
            point = true;
        }

    }

    void fail2(GameObject bad1, GameObject bad2)
    {
        if (timer < 2.5 && point)
        {
            ManagerScript.score -= 2;
            FadeIn(bad1);
            FadeIn(bad2);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(bad1);
            FadeOut(bad2);
            point = true;
        }
    }

    void fail3(GameObject bad1, GameObject bad2, GameObject bad3)
    {
        if (timer < 2.5 && point)
        {
            ManagerScript.score -= 3;
            FadeIn(bad1);
            FadeIn(bad2);
            FadeIn(bad3);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(bad1);
            FadeOut(bad2);
            FadeOut(bad3);
            point = true;
        }
    }
}
