using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneScript : MonoBehaviour
{
    public float time;  //��ǥ �ð�
    public string next_scene;

    public float timer = 0; //���� �ð�
    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > time)
        {
           SceneManager.LoadScene(next_scene);
        }
    }
}
