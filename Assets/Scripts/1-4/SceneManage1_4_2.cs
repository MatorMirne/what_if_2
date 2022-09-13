using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_4_2 : MonoBehaviour
{
    public GameObject water, door;

    void Update()
    {
        if (door.GetComponent<DoorScript>().doorClick || water.GetComponent<WaterRoom>().pos.y >= 0)
        {
            SceneManager.LoadScene("1-4Score");
        }
    }
}
