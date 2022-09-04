using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcButtonScript : MonoBehaviour
{
    public GameObject wind;
    public bool isAcOn = false;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAcOn)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                wind.SetActive(false);
                isAcOn = false;
            }
        }
    }

    private void OnMouseDown()
    {
        wind.SetActive(true);
        isAcOn = true;
    }
}
