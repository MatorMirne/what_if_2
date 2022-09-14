using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanScript : MonoBehaviour
{
    public static bool isGood = false;

    float timer = 0;
    bool isGaming = false;
    bool isEnd = false;

    public GameObject beforeFire, fireOff, fireOn, fireBig;
    public GameObject mayo, tap;
    public GameObject su, surSu;

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer > 1.7 && !isGaming && !isEnd)
        {
            su.SetActive(false);
            surSu.SetActive(true);
            beforeFire.GetComponent<SpriteRenderer>().enabled = false;
            fireOn.SetActive(true);
            isGaming = true;
        }
        if (isGaming && !isEnd)
        {
            if (tap.GetComponent<TapScript>().isOn)
            {
                Debug.Log("tap");
                fireOn.SetActive(false);
                fireBig.SetActive(true);
                isEnd = true;
                timer = 0;
            }
            else if (mayo.GetComponent<MayoScript>().isPour)
            {
                Debug.Log("mayo");
                fireOn.SetActive(false);
                fireOff.SetActive(true);
                isEnd = true;
                timer = 0;
                isGood = true;
            }
        }
        if(timer > 1.7 && isEnd)
        {
            SceneManager.LoadScene("2-2Score");
        }
    }
}
