using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_car1_6_2 : MonoBehaviour
{
    public GameObject scenemanager;
    Vector2 start_pos;
    float time;
    void Start()
    {
        start_pos = transform.position;
        time = 0;
    }

    void Update()
    {
        if (!scenemanager.GetComponent<SceneManager1_6_2>().gameover)
        {
            time += Time.deltaTime;
            transform.position = start_pos + new Vector2(time / 3, 0);

            if (transform.position.x > 4.737602f)
            {
                Debug.Log("Game Clear !");
            }
        }
    }
}
