using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer1_2_1 : MonoBehaviour
{
    public float time_total;
    public float time_now;
    public GameObject scene_manager;

    Transform timer_transform;
    Vector2 fullsize;
    Vector2 pos;
    float gauge;

    void Awake()
    {
        time_now = 0;
        timer_transform = GetComponent<Transform>();
        fullsize = timer_transform.localScale;
        pos = timer_transform.position;
        gauge = 0;
    }

    void Start()
    {
        timer_transform.position = pos - new Vector2(2.3f, 0);
        pos = timer_transform.position;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (gauge < 1)
        {
            time_now += Time.deltaTime;
            gauge = time_now / time_total * 20;

            timer_transform.localScale = fullsize * new Vector2(gauge, 1);
            timer_transform.position = pos + new Vector2(gauge * 2.3f, 0);

            yield return new WaitForSeconds(0.02f);
        }

        Debug.Log("Time Over !");
        ManagerScript.chapter1_2score = false;
        TimeOver();
    }

    protected void TimeOver()
    {
        scene_manager.GetComponent<SceneManage1_2_1>().LoadNextScene();
    }
}
