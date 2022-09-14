using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject lightOn, idle, light, background;
    public static bool isOn = false;






    private void OnMouseDown()
    {
        isOn = true;
        background.gameObject.SetActive(false);
        light.SetActive(false);
        idle.SetActive(false);
        lightOn.SetActive(true);
        
    }
}
