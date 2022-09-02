using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch1_2_1elec : MonoBehaviour
{
    public GameObject scenemanager;
    void OnMouseDown()
    {
        scenemanager.GetComponent<SceneManage1_2_1>().Elec_Touch();
    }
}
