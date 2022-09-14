using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_1_3 : MonoBehaviour
{
    public GameObject gameObject;
    CutSceneScript cutSceneScript;

    public GameObject roop1;
    public GameObject roop2;

    void Start()
    {
        cutSceneScript = gameObject.GetComponent<CutSceneScript>();

        if (ManagerScript.chapter1_1repeat_num == 0)
        {
            cutSceneScript.next_scene = "Chapter1";
        }
        else
        {
            cutSceneScript.next_scene = "1-1-4";
        }

        if (ManagerScript.chapter1_1repeat_num == 1)
        {
            roop1.SetActive(true);
        }
        else if (ManagerScript.chapter1_1repeat_num >= 2)
        {
            roop2.SetActive(true);
        }

    }


}
