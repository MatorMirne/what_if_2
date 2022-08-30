using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NegChoice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ManagerScript.score--;
        ManagerScript.chapter1_repeat_num++;
        Debug.Log(ManagerScript.score);
        SceneManager.LoadScene("1-1-5");
    }
}
