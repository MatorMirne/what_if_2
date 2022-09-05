using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_6_1 : MonoBehaviour
{
    public GameObject lookUp, head, headMes;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2.5 && timer < 3)
        {
            head.SetActive(true);
        }
        if(timer > 5 && timer < 5.5)
        {
            lookUp.SetActive(true);
        }
        if(timer > 7.5 && timer < 8)
        {
            headMes.SetActive(true);
        }
        if(timer > 10)
        {
            //  ���� scene����
            Debug.Log("to next scene");
        }
    }
}
