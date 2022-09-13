using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_3_1 : MonoBehaviour
{
    public GameObject wangScript, suScript;

    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 4)
        {
            SceneManager.LoadScene("2-3-2");
        }
        else if(timer > 1.5)
        {
            wangScript.SetActive(true);
            suScript.SetActive(true);
        }
    }
}
