using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wang1_5_2 : MonoBehaviour
{
    public Sprite walk1, walk2;

    Vector2 startpos;
    Vector2 move;

    float time;
    float walk_time;

    private void Start()
    {
        startpos = transform.position;
        move = new Vector2(0, 0);
    }

    private void Update()
    { 
        time += Time.deltaTime;
        walk_time += Time.deltaTime;
        if (walk_time > 0.5f)
        {
            walk_time = 0;
            Image_Change();
        }
        transform.position = startpos + new Vector2(0,time) + move;
    }

    void Image_Change()
    {
        if( gameObject.GetComponent<SpriteRenderer>().sprite == walk1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = walk2;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = walk1;
        }
    }
    
    public void Move_Right()
    {
        if (move.x < 2)
        {
            move += new Vector2(1, 0);
        }
    }

    public void Move_Left()
    {
        if (move.x > -2)
        {
            move += new Vector2(-1, 0);
        }
    }
}
