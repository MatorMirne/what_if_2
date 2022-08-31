using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NegChoice : MonoBehaviour
{
    private void OnMouseDown()
    {
        ManagerScript.score--;
        ManagerScript.chapter1_1repeat_num++;
        Debug.Log(ManagerScript.score);
        SceneManager.LoadScene("1-1-5");
    }
}
