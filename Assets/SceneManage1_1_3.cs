using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_1_3 : MonoBehaviour
{
    public GameObject gameObject;
    CutSceneScript cutSceneScript;

    void Start()
    {
        cutSceneScript = gameObject.GetComponent<CutSceneScript>();

        if (ManagerScript.chapter1_repeat_num == 0)
        {
            cutSceneScript.next_scene = "Chapter1";
        }
        else
        {
            cutSceneScript.next_scene = "1-1-4";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
