using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage2_1 : MonoBehaviour
{
    public static bool goodEnd = false;

    public GameObject temperature, fire;
    float timer, fixedTimer = 0;
    float multiplier = 1;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = temperature.transform.position;
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

        if (pos.y >= -1.5 && PlugOnScript.plugOnNum <= 3)
        {
            multiplier = 0;
            goodEnd = true;
        }

        if(fixedTimer > 7 && pos.y < -0.2)
        {
            goodEnd = true;
            Debug.Log("to next scene");
        }
        if(pos.y >= -0.2)
        {
            fire.SetActive(true);
            multiplier = 0;
            Debug.Log("bad end");
            //  ???????
        }

        Debug.Log(pos.x + " " + pos.y);
        temperature.transform.position = new Vector2(pos.x, pos.y + 0.0007f * multiplier);
        pos = temperature.transform.position;
    }
}
