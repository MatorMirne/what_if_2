using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cholice_good_1_3 : MonoBehaviour
{
    public GameObject scene_manager;

    private void OnMouseDown()
    {
        scene_manager.GetComponent<SceneManage1_3_2>().KeepGoing();
    }
}
