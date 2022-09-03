using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject lightOn, idle, light, background;
    public static bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        isOn = true;
        background.gameObject.SetActive(false);
        light.SetActive(false);
        idle.SetActive(false);
        lightOn.SetActive(true);
        
    }
}
