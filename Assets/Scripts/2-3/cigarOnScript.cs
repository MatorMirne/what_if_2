using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cigarOnScript : MonoBehaviour
{
    public GameObject lightOn, lightOff;






    private void OnMouseDown()
    {
        lightOn.SetActive(false);
        lightOff.SetActive(true);
    }
}
