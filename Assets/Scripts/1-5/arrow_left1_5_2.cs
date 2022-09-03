using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_left1_5_2 : MonoBehaviour
{
    public GameObject wang;

    void OnMouseDown()
    {
        wang.GetComponent<wang1_5_2>().Move_Left();
    }
}
