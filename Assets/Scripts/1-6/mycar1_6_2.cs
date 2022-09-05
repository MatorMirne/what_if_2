using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycar1_6_2 : MonoBehaviour
{
    public GameObject scenemanager;
    public GameObject car1, car2;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector2.Distance(car1.transform.position, transform.position) < 3.5f)
        {
            scenemanager.GetComponent<SceneManager1_6_2>().GameOver();
        }
    }
}
