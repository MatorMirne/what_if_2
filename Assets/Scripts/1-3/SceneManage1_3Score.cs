using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_3Score : SceneBase
{
    public GameObject sprite;
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
        if (timer < 2.5 && point)
        {
            FadeIn(sprite);
            point = false;
        }
        else if (timer > 2.5 && !point)
        {
            FadeOut(sprite);
            point = true;
        }
        if(timer > 4.5)
        {
            SceneManager.LoadScene("TimeTransEtoN");
        }
    }
}
