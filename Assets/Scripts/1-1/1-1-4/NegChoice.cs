using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NegChoice : MonoBehaviour
{
    private void OnMouseDown()
    {
        ManagerScript.chapter1_score--;
        ManagerScript.chapter1_1repeat_num++;
        ManagerScript.chapter1_1score = false;
        Debug.Log("(���ھ� -1) "+"���� ���ھ�:"+ManagerScript.chapter1_score);
        SceneManager.LoadScene("1-1-5");
    }
}
