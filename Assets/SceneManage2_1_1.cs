using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage2_1_1 : MonoBehaviour
{
    public GameObject suWalk, suTalk, suStand;
    public GameObject wangWalk, wangSit, wangTalk, wangSeek;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 8)
        {
            Debug.Log("to next scene");
        }
        else if(timer > 6.5)
        {
            wangSeek.SetActive(true);
        }
        else if(timer > 5)
        {
            wangWalk.SetActive(false);
            suWalk.SetActive(false);
            wangTalk.SetActive(false);
            suTalk.SetActive(false);

            wangSit.SetActive(true);
            suStand.SetActive(true);
        }
        else if(timer > 3)
        {
            wangTalk.SetActive(true);
        }
        else if(timer > 1.5)
        {
            suTalk.SetActive(true);
        }
    }
}
