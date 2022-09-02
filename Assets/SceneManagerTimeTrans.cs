using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerTimeTrans : SceneBase
{
    public GameObject before, after;
    public string nextScene;
    float timer = 0;
    bool point1 = true;
    bool point2 = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (point1 && timer > 1)
        {
            FadeOut(before);
            point1 = false;
        }
        if (point2 && timer > 1.5)
        {
            FadeIn(after);
            point2 = false;
        }
        if (timer > 3.5)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
