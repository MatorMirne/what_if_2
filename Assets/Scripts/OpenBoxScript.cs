using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBoxScript : MonoBehaviour
{
    public GameObject belt, speeder, body;

    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = belt.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        belt.transform.position = new Vector2(pos.x, pos.y + 2);

        pos = speeder.transform.position;
        speeder.transform.position = new Vector2(pos.x, pos.y + 2);

        pos = body.transform.position;
        body.transform.position = new Vector2(pos.x, pos.y + 2);
    }
}
