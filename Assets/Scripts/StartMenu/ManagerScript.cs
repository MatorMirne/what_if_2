using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    // Chapter 1 반복횟수
    static public int chapter1_1repeat_num =0;
    static public int chapter1_score = 100;

    public enum datas_1_5 { clear, hole, elec };
    static public int data_1_5 = (int)datas_1_5.clear; 

    // Debug.Log("(스코어 -n) " + "현재 스코어:" + ManagerScript.chapter1_score);
}
