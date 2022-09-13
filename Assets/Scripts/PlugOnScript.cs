using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugOnScript : MonoBehaviour
{
    public static int plugOnNum = 5;
    public GameObject plugOff, plugOn;

    private void OnMouseDown()
    {
        plugOnNum--;
        plugOn.SetActive(false);
        plugOff.SetActive(true);
        Debug.Log(plugOnNum);
    }
}
