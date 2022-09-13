using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject light, dark;
    public bool isLight = false;

    private void OnMouseDown()
    {
        isLight = true;
        light.SetActive(true);
        dark.SetActive(false);
    }
}
