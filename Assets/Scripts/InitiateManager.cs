using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateManager : MonoBehaviour
{
    
    void Start()
    {
        ManagerScript.chapter1_score = 100;

        ManagerScript.chapter1_1score = true;
        ManagerScript.chapter1_1repeat_num = 0; // Chapter1-1 ¹Ýº¹È½¼ö

        ManagerScript.chapter1_2score = true;
        ManagerScript.chapter1_3score = true;
        ManagerScript.chapter1_4score = true;
        ManagerScript.chapter1_5score = true;
        ManagerScript.chapter1_6score = true;
        ManagerScript.chapter1_7score = true;

        ManagerScript.chapter2_score = 100;

        ManagerScript.chapter2_1score = true;
        ManagerScript.chapter2_2score = true;
        ManagerScript.chapter2_3score = true;
        ManagerScript.chapter2_4score = true;
        ManagerScript.chapter2_5score = true;
        ManagerScript.chapter2_6score = true;
        ManagerScript.chapter2_7score = true;
    }


}
