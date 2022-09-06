using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cigarOnScript : MonoBehaviour
{
    public GameObject lightOn, lightOff;

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
        lightOn.SetActive(false);
        lightOff.SetActive(true);
    }
}
