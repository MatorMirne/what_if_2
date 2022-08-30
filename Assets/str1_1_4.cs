using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class str1_1_4 : MonoBehaviour
{
    public Sprite roop1;
    public Sprite roop2;

    private void Start()
    {
        if (ManagerScript.chapter1_repeat_num == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = roop1;
        }
        else if (ManagerScript.chapter1_repeat_num >= 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = roop2;
        }

    }

}
