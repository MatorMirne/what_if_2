using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_3_2 : SceneBase
{
    public string next_scene;

    public GameObject background;
    public Sprite background2;

    public bool point1;
    public GameObject choice1, choice2;

    float time;


    private void Start()
    {
        time = 0;
        point1 = true;
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;


        if (time > 0.5f)
        {
            background.GetComponent<SpriteRenderer>().sprite = background2;
        }

        if (time > 1.0f&& point1)
        {
            point1 = false;
            FadeIn(choice1);
            FadeIn(choice2);
        }

        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(next_scene);
    }
}
