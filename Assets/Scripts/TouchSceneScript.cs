using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchSceneScript : MonoBehaviour
{
    public string next_scene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(next_scene);
    }
}
