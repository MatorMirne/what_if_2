using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_1_2 : MonoBehaviour
{
    public GameObject roop1;
    public GameObject roop2;

    void Start()
    {
        if(ManagerScript.chapter1_1repeat_num != 0)
        {
            if (ManagerScript.chapter1_1repeat_num == 1)
            {
                roop1.SetActive(true);
            }
            else
            {
                roop2.SetActive(true);
            }
        }
    }

}
