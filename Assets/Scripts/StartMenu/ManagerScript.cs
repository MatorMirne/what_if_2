using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{

    static public int chapter1_score = 100;

    static public bool chapter1_1score = true;
    static public int chapter1_1repeat_num =0; // Chapter1-1 반복횟수

    static public bool chapter1_2score = true;
    static public bool chapter1_3score = true;
    static public bool chapter1_4score = true;
    static public bool chapter1_5score = true;
    static public bool chapter1_6score = true;
    static public bool chapter1_7score = true;

    static public int chapter2_score = 100;

    static public bool chapter2_1score = true;
    static public bool chapter2_2score = true;
    static public bool chapter2_3score = true;
    static public bool chapter2_4score = true;
    static public bool chapter2_5score = true;
    static public bool chapter2_6score = true;
    static public bool chapter2_7score = true;

    public enum datas_1_5 { clear, hole, elec };
    static public int data_1_5 = (int)datas_1_5.clear; 

    // Debug.Log("(스코어 -n) " + "현재 스코어:" + ManagerS cript.chapter1_score);
}
