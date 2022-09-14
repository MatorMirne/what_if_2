using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2_4score : SceneBase
{
    public string next_scene;
    public GameObject a;
    bool point =false;

    public float timer = 0; //현재 시간

    void Start()
    {
        FadeIn(a);
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer > 2f && !point)
        {
            point = true;
            FadeOut(a);
        }

        if (timer > 3f)
        {
            SceneManager.LoadScene(next_scene);
        }
    }
}
