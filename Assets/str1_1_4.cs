using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class str1_1_4 : MonoBehaviour
{
    public Sprite loop1;
    public Sprite loop2;

    private void Start()
    {
        if (ManagerScript.chapter1_1repeat_num == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = loop1;
        }
        else if (ManagerScript.chapter1_1repeat_num >= 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = loop2;
        }

    }

}
