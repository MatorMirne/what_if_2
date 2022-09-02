using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch1_2_1back : MonoBehaviour
{
    public GameObject scenemanager;
    private void OnMouseDown()
    {
        scenemanager.GetComponent<SceneManage1_2_1>().Elec_out_Touch();
    }
}
