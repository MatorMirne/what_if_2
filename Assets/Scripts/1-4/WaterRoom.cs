using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRoom : MonoBehaviour
{
    public Vector2 pos;

    private void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(pos.x + " " + pos.y);
        transform.position = new Vector2(pos.x, pos.y + 0.01f);
        pos = transform.position;
    }
}
