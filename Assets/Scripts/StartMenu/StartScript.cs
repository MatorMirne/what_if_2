using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Debug.Log("Start!");
        SceneManager.LoadScene("SampleStage");
    }
}
