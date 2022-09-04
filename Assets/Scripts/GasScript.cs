using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasScript : MonoBehaviour
{
    public GameObject gasOn, gasOff;
    public static bool isOff = false;

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
        isOff = true;
        gasOn.SetActive(false);
        gasOff.SetActive(true);
    }
}
