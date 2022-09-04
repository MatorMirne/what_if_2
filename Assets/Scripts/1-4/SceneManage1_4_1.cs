using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_4_1 : MonoBehaviour
{
    public GameObject sleep, wake, surprise;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4.5)
        {
            SceneManager.LoadScene("1-4-2");
        }
        else if (timer > 3)
        {
            Debug.Log("surprise");
            wake.SetActive(false);
            surprise.SetActive(true);
        }
        else if (timer > 1.5)
        {
            sleep.SetActive(false);
            wake.SetActive(true);
        }
    }
}
