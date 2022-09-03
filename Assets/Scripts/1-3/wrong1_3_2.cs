using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrong1_3_2 : MonoBehaviour
{
    float time;
    Vector2 pos;
    private void Start()
    {
        time = 0;
        pos = gameObject.transform.position;
    }
    private void Update()
    {
        time += Time.deltaTime;
        gameObject.transform.position = pos + new Vector2(0, time/2);
        if (time > 1f)
        {
            Destroy(gameObject);
        }
    }
}
