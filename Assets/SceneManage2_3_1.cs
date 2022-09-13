using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_3_1 : MonoBehaviour
{
    public GameObject wangScript, suScript;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 4)
        {
            //  ´ÙÀ½ ¾ÀÀ¸·Î
        }
        else if(timer > 1.5)
        {
            wangScript.SetActive(true);
            suScript.SetActive(true);
        }
    }
}
