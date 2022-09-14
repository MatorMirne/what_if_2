using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_6_1 : MonoBehaviour
{
    public GameObject lookUp, head, headMes;

    float timer = 0;

 



    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer > 2.5 && timer < 3)
        {
            lookUp.SetActive(true);
        }
        if(timer > 4 && timer < 5.5)
        {
            headMes.SetActive(true);
        }
        if(timer > 6)
        {
            //  다음 scene으로
            Debug.Log("to next scene");
            SceneManager.LoadScene("1-6-2");
        }
    }
}
