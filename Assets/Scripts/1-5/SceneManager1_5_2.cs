using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1_5_2 : MonoBehaviour
{
    public string next_scene;
    public void GameOver()
    {
        Debug.Log("���� ����");
        SceneManager.LoadScene(next_scene);
    }
}
