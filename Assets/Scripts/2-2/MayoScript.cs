using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoScript : MonoBehaviour
{
    public bool isPour = false;



    private void OnMouseDown()
    {
        isPour = true;
    }
}
