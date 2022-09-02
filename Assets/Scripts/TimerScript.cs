using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class TimerScript : MonoBehaviour
{
    public float time_total;
    public float time_now;

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
        while (gauge<1)
        {
            time_now += Time.deltaTime;
            gauge = time_now / time_total*20;

            timer_transform.localScale = fullsize * new Vector2(gauge, 1);
            timer_transform.position = pos + new Vector2(gauge * 2.3f, 0);

            yield return new WaitForSeconds(0.02f);
        }

        Debug.Log("Time Over !");
        
    }
}
