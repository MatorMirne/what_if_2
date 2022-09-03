using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_right1_5_2 : MonoBehaviour
{
    public GameObject wang;

    void OnMouseDown()
    {
        wang.GetComponent<wang1_5_2>().Move_Right();
    }
}
