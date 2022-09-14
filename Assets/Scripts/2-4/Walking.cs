using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public GameObject wangWalk1, wangWalk2, suWalk1, suWalk2, wangSur, suSur;
    public bool isGaming = false;

    float timer = 0;
    int walkSprite;

    Vector2 pos;
    Vector2 suPos;

    // Start is called before the first frame update
    void Start()
    {
        pos = wangWalk1.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        walkSprite = (int)timer % 2;

        if(walkSprite == 0)
        {
            wangWalk2.SetActive(false);
            suWalk2.SetActive(false);

            wangWalk1.SetActive(true);
            suWalk1.SetActive(true);
        }
        if(walkSprite == 1)
        {
            wangWalk1.SetActive(false);
            suWalk1.SetActive(false);

            wangWalk2.SetActive(true);
            suWalk2.SetActive(true);
        }

        wangWalk1.transform.position = new Vector2(pos.x - 0.017f, pos.y);

        if(pos.x >= 1.13)
        {
            pos = wangWalk1.transform.position;
            suPos = new Vector2(pos.x - 0.7f, pos.y);
            wangWalk2.transform.position = pos;
            suWalk1.transform.position = suPos;
            suWalk2.transform.position = suPos;
            wangSur.transform.position = pos;
            suSur.transform.position = suPos;
        }
        else
        {
            wangWalk1.SetActive(false);
            wangWalk2.SetActive(false);
            suWalk1.SetActive(false);
            suWalk2.SetActive(false);
            wangSur.SetActive(true);
            suSur.SetActive(true);
            isGaming = true;
        }

    }
}
