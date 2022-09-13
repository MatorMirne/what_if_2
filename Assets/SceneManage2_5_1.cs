using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage2_5_1 : MonoBehaviour
{
    public GameObject fireText;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 4.5)
        {
            //  ´ÙÀ½ ¾ÀÀ¸·Î
        }
        else if(timer > 2)
        {
            fireText.SetActive(true);
        }
    }
}
