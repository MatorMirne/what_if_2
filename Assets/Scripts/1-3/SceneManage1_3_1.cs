using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_3_1 : MonoBehaviour
{
    public GameObject sleep, phoneOff, phoneOn, background;
    float timer = 0;




    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer > 1.5 && timer <= 3)
        {
            sleep.SetActive(false);
            phoneOff.SetActive(true);
        }
        else if(timer > 3 && timer <= 4.5)
        {
            phoneOff.SetActive(false);
            phoneOn.SetActive(true);
        }
        if (timer > 4.5)
        {
            SceneManager.LoadScene("1-3-2");
        }
    }
}
