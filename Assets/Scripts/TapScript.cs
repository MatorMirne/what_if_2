using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{
    public Sprite wateron;
    public bool isOn = false;


    private void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = wateron;
        isOn = true;
        ManagerScript.chapter2_2score = false;
        ManagerScript.chapter2_score--;
    }
}
