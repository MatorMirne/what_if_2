using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugOnScript : MonoBehaviour
{
    public static int plugOnNum = 5;
    public GameObject plugOff, plugOn;
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
        plugOnNum--;
        plugOn.SetActive(false);
        plugOff.SetActive(true);
        Debug.Log(plugOnNum);
    }
}
