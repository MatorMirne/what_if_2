using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_car1_6_2 : MonoBehaviour
{
    public GameObject scenemanager;

    Vector2 start_pos;
    float end_pos;

    float time;
    void Start()
    {
        start_pos = transform.position;
        end_pos = 3.34f;
        time = 0;
    }

    void Update()
    {
        if (!scenemanager.GetComponent<SceneManager1_6_2>().gameover)
        {
            time += Time.deltaTime;
            transform.position = start_pos + new Vector2((end_pos - start_pos.x) * (time / 11f), 0);

            if (time>11f)
            {
                scenemanager.GetComponent<SceneManager1_6_2>().GameClear();
            }
        }
    }

}
