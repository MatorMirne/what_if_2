using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1 : MonoBehaviour
{
    public GameObject[] gauge = new GameObject[5];
    float timer, fixedTimer = 0;
    int curGauge = 0;
    float multiplier = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * multiplier;
        fixedTimer += Time.deltaTime;

        switch (PlugOnScript.plugOnNum)
        {
            case 5:
                multiplier = 1.7f;
                break;
            case 4:
                multiplier = 1.2f;
                break;
            case 3:
                multiplier = 0.7f;
                break;
            case 2:
                multiplier = 0.4f;
                break;
            case 1:
                multiplier = 0.2f;
                break;
            case 0:
                multiplier = 0;
                break;
        }

        if(timer > 1 && timer < 2)
        {
            gauge[0].SetActive(true);
            curGauge = 1;
        }
        if(timer > 2 && timer < 3)
        {
            gauge[1].SetActive(true);
            curGauge = 2;
        }
        if (timer > 3 && timer < 4)
        {
            gauge[2].SetActive(true);
            curGauge = 3;
        }
        if (timer > 4 && timer < 5)
        {
            gauge[3].SetActive(true);
            curGauge = 4;
        }
        if (timer > 5 && timer < 6)
        {
            gauge[4].SetActive(true);
            curGauge = 5;
        }

        if(PlugOnScript.plugOnNum <= 3 && curGauge >= 4)
        {
            gauge[3].SetActive(false);
            gauge[4].SetActive(false);
        }

        if(curGauge == 5 && fixedTimer > 7)
        {
            //  성공 or 실패 전부 여기서 loadscene
            Debug.Log("game over!");
        }
    }
}
