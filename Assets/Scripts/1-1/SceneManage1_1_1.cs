using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_1_1 : MonoBehaviour
{
    public GameObject saying;
    void Start()
    {
        if (ManagerScript.chapter1_repeat_num >= 2)
        {
            saying.SetActive(true);
        }
    }

}
