using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_7 : SceneBase
{
    public GameObject lever, fog, ac;
    float timer = 0;
    bool isFoggy = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lever.GetComponent<LeverScript>().isLight)
        {
            timer += Time.deltaTime;

            //  1Â÷ ±è¼­¸²
            if(timer > 2 && timer < 3)
            {
                isFoggy = true;
                FadeIn(fog);
            }
            if(timer > 2 && timer < 6 && isFoggy)
            {
                if (ac.GetComponent<AcButtonScript>().isAcOn)
                {
                    isFoggy = false;
                    FadeOut(fog);
                }
            }
            if(timer > 6 && timer < 7 && isFoggy)
            {
                //game over
                ManagerScript.chapter1_7score = false;
            }

            //  2Â÷ ±è¼­¸²
            if (timer > 9 && timer < 10)
            {
                isFoggy = true;
                FadeIn(fog);
            }
            if (timer > 9 && timer < 13 && isFoggy)
            {
                if (ac.GetComponent<AcButtonScript>().isAcOn)
                {
                    isFoggy = false;
                    FadeOut(fog);
                }
            }
            if (timer > 13 && timer < 14 && isFoggy)
            {
                //game over
                ManagerScript.chapter1_7score = false;
            }

            //  3Â÷ ±è¼­¸²
            if (timer > 16 && timer < 17)
            {
                isFoggy = true;
                FadeIn(fog);
            }
            if (timer > 16 && timer < 20 && isFoggy)
            {
                if (ac.GetComponent<AcButtonScript>().isAcOn)
                {
                    isFoggy = false;
                    FadeOut(fog);
                }
            }
            if (timer > 20 && timer < 21 && isFoggy)
            {
                ManagerScript.chapter1_7score = false;
                //game over
            }

            if(timer > 22)
            {
                //stage clear
                SceneManager.LoadScene("1-7ScoreGood");
            }
        }
    }
}
