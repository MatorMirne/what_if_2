using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_2_1 : MonoBehaviour
{
    public GameObject buttonMain, buttonSub1, buttonSub2, buttonSub3;

    // Update is called once per frame
    void Update()
    {
        if(!buttonMain.gameObject.GetComponent<ButtonScript>().isOn || !buttonSub1.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub2.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub3.gameObject.GetComponent<ButtonScript>().isOn)
        {
            Debug.Log("elec clear");
        }
    }
}
