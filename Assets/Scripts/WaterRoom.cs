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
    void Update()
    {
        Debug.Log(pos.x + " " + pos.y);
        transform.position = new Vector2(pos.x, pos.y + 0.0007f);
        pos = transform.position;
    }
}
