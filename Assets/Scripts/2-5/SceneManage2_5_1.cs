using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_5_1 : MonoBehaviour
{
    public GameObject fireText;

    float timer = 0;





    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer > 4.5)
        {
            //  ´ÙÀ½ ¾ÀÀ¸·Î
            SceneManager.LoadScene("2-5-2");
        }
        else if(timer > 2)
        {
            fireText.SetActive(true);
        }
    }
}
