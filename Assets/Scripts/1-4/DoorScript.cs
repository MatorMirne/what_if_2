using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool doorClick = false;


    private void OnMouseDown()
    {
        doorClick = true;
    }
}
