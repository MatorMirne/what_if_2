using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice_bad_1_3 : MonoBehaviour
{
    public GameObject error_message;
    private void OnMouseDown()
    {
        Instantiate(error_message);
        ManagerScript.chapter1_score--;
        Debug.Log("(���ھ� -1) " + "���� ���ھ�:" + ManagerScript.chapter1_score);
    }
}
