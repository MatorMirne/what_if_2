using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SceneManagerChapter1Score : MonoBehaviour
{
    public Sprite fail;

    public GameObject score1;
    public GameObject score2;
    public GameObject score3;
    public GameObject score4;
    public GameObject score5;
    public GameObject score6;
    public GameObject score7;
    public GameObject score;

    float time = 0;
    bool end = false;

    void Update()
    {
        time += Time.deltaTime;

        if (time > 1f)
        {
            if (!ManagerScript.chapter1_1score)
            {
                score1.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score1.SetActive(true);
        }

        if (time > 2f)
        {
            if (!ManagerScript.chapter1_2score)
            {
                score2.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score2.SetActive(true);
        }

        if (time > 3f)
        {
            if (!ManagerScript.chapter1_3score)
            {
                score3.GetComponent<SpriteRenderer>().sprite = fail;
            }   
            score3.SetActive(true);
        }

        if (time > 4f)
        {
            if (!ManagerScript.chapter1_4score)
            {
                score4.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score4.SetActive(true);
        }

        if (time > 5f)
        {
            if (!ManagerScript.chapter1_5score)
            {
                score5.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score5.SetActive(true);
        }

        if (time > 6f)
        {
            if (!ManagerScript.chapter1_6score)
            {
                score6.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score6.SetActive(true);
        }

        if (time > 7f)
        {
            if (!ManagerScript.chapter1_7score)
            {
                score7.GetComponent<SpriteRenderer>().sprite = fail;
            }
            score7.SetActive(true);
        }

        if (time > 8f)
        {
            score.GetComponent<Text>().text = ManagerScript.chapter1_score.ToString();
            score.SetActive(true);
            end = true;
        }
    }

    public void End()
    {
        if (end)
        {
            SceneManager.LoadScene("2-1-1");
        }
    }
}
