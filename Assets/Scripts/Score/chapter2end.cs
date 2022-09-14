using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter2end : MonoBehaviour
{
    public GameObject scenemanager;

    private void OnMouseDown()
    {
        scenemanager.GetComponent<SceneManagerChapter2Score>().End();
    }
}
