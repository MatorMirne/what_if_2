using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasScript : MonoBehaviour
{
    public GameObject gasOn, gasOff;
    public static bool isOff = false;




    private void OnMouseDown()
    {
        isOff = true;
        gasOn.SetActive(false);
        gasOff.SetActive(true);
    }
}
