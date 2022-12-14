using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafePinScript : MonoBehaviour
{
    public GameObject fireExt;

    Vector3 pos = Vector3.zero;
    public float timer = 0;

    bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = fireExt.transform.position;

        if (fireExt.GetComponent<FireExtScript>().isFloat && isClicked)
        {
            //  한번 돌릴때마다 점수 까짐

            pos.x = 0.03f;
            Debug.Log("shake");

            if (timer > 0.4f)
            {
                transform.position += pos;
                isClicked = false;
            }
            else if (timer > 0.3f)
            {
                transform.position -= pos;
            }
            else if (timer > 0.2f)
            {
                transform.position += pos;
            }
            else if (timer > 0.1f)
            {
                transform.position -= pos;
            }
        }
        else if(!fireExt.GetComponent<FireExtScript>().isFloat && isClicked)
        {
            pos.x = 1;
            transform.position -= pos;
        }
    }

    private void OnMouseDown()
    {
        timer = 0;
        isClicked = true;
    }
}
