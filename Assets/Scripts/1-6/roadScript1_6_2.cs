using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadScript1_6_2 : MonoBehaviour
{
    float time;
    Vector2 start_pos;

    void Start()
    {
        time = 0;
        start_pos = transform.position;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        transform.position = start_pos - new Vector2(0, time*5);

        if(transform.position.y< -9.87f)
        {
            //Debug.Log(time);
            Destroy(gameObject);
        }
    }
}
