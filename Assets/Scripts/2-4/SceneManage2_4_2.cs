using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_4_2 : MonoBehaviour
{
    public string next_scene;

    public void GameClear()
    {
        StartCoroutine(NextScene(1));
    }

    IEnumerator NextScene(float deadline)
    {
        float time = 0;
        while (time < deadline)
        {
            time += Time.deltaTime;
            yield return null;
        }
        SceneManager.LoadScene(next_scene);
    }
}
