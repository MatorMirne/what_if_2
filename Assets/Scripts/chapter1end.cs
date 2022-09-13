using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter1end : MonoBehaviour
{
    public GameObject scenemanager;

    private void OnMouseDown()
    {
        scenemanager.GetComponent<SceneManagerChapter1Score>().End();
    }
}
