using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNext2_4 : MonoBehaviour
{
    public GameObject Walk;

    private void OnMouseDown()
    {
        if (Walk.GetComponent<Walking>().isGaming)
        {
            SceneManager.LoadScene("2-4-2");
        }

    }
}
