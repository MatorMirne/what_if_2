using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanScript : MonoBehaviour
{
    float timer = 0;
    bool isGaming = false;
    bool isEnd = false;

    public GameObject beforeFire, fireOff, fireOn, fireBig;
    public GameObject mayo, tap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1.7 && !isGaming && !isEnd)
        {
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
            }
        }
        if(timer > 1.7 && isEnd)
        {
            if (tap.GetComponent<TapScript>().isOn)
            {
                Debug.Log("다시시작");
                //  게임 다시 시작
            }
            else if (mayo.GetComponent<MayoScript>().isPour)
            {
                Debug.Log("다음 스테이지로");
                //  다음 스테이지로
            }
        }
    }
}
