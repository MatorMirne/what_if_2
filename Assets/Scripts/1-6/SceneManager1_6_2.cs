using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            //Debug.Log("새로운 road 생성");
            Instantiate(road_base);
            create_road_timer = 0;
        }
    }

    public void GameOver()
    {
        ManagerScript.chapter1_6score = false;
        SceneManager.LoadScene("1-6ScoreBad");
    }

    public void GameClear()
    {
        SceneManager.LoadScene("1-6ScoreGood");
    }
}
