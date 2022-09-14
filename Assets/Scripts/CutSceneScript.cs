using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneScript : MonoBehaviour
{
    public float time;  //목표 시간
    public string next_scene;

    public float timer = 0; //현재 시간
    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > time)
        {
           SceneManager.LoadScene(next_scene);
        }
    }
}
