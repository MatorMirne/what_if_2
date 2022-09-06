using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager1_6_2 : MonoBehaviour
{
    public GameObject road_base;

    public bool gameover;
    float time;
    float create_road_timer;

    void Start()
    {
        time = 0;
        gameover = false;
    }

    void Update()
    {
        time += Time.deltaTime;
        create_road_timer += Time.deltaTime;

        if (create_road_timer > 1.97f)
        {
            //Debug.Log("货肺款 road 积己");
            Instantiate(road_base);
            create_road_timer = 0;
        }
    }

    public void GameOver()
    {
        //Debug.Log("Game Over ...");
    }
}
