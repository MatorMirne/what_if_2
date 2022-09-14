using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WangDescend : MonoBehaviour
{
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(pos.x, pos.y - 0.08f);
        pos = transform.position;

        if(pos.y <= -5.9)
        {
            //  �� �Ѿ
            SceneManager.LoadScene("Chapter2Ending");
        }
    }
}
