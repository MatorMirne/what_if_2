using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMoveScript : MonoBehaviour
{
    public GameObject manager;
    Vector2 pos;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        pos = manager.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        manager.transform.position = new Vector2(pos.x - 0.0009f, pos.y);

        if(pos.x > 0)
        {
            pos = manager.transform.position;
        }
    }
}
