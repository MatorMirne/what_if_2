using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_2_1 : MonoBehaviour
{
    public GameObject window;
    public GameObject buttonMain, buttonSub1, buttonSub2, buttonSub3;
    public GameObject big_elec;
    public GameObject multiplug;
    public string next_scene;

    bool big_elec_on;
    bool big_elec_ready;

    public static bool elec_clear = false;
    public static bool window_clear = false;
    public static bool multiplug_clear = false;

    Transform big_elec_transform;
    Vector2 temp;

    private void Awake()
    {
        big_elec_on = false;
        big_elec_ready = true;
    }

    private void Start()
    {
        Input.multiTouchEnabled = false;
        big_elec_transform = big_elec.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!buttonMain.gameObject.GetComponent<ButtonScript>().isOn || !buttonSub1.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub2.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub3.gameObject.GetComponent<ButtonScript>().isOn)
        {
            elec_clear = true;
        }
        else
        {
            elec_clear = false;
        }
        if (!window.GetComponent<WindowScript>().isOpen)
        {
            window_clear = true;
        }
        else
        {
            window_clear = false;
        }
        if (multiplug.GetComponent<MultiPlug>().isUp)
        {
            multiplug_clear = true;
        }
        else
        {
            multiplug_clear = false;
        }
        if(elec_clear && window_clear && multiplug_clear)
        {
            SceneManager.LoadScene("1-2Score");
        }
    }

    public void Elec_Touch()
    {
        if (!big_elec_on && big_elec_ready)
        {
            big_elec_on = true;
            big_elec_ready = false;
            StartCoroutine(ShowOn());
        }
    }

    IEnumerator ShowOn()
    {
        float count = 0;
        temp = big_elec_transform.position;
        while (big_elec_transform.position.y < 1.07f)
        {
            count += 0.3f;
            big_elec_transform.position = temp + new Vector2(0, count);
            yield return new WaitForSeconds(0.01f);
        }
        big_elec_ready = true;
    }

    public void Elec_out_Touch()
    {
        if (big_elec_on && big_elec_ready)
        {
            big_elec_on = false;
            big_elec_ready = false;
            StartCoroutine(ShowOff());
        }
    }

    IEnumerator ShowOff()
    {
        float count = 0;
        temp = big_elec_transform.position;
        while (big_elec_transform.position.y > -5.04f)
        {
            count += 0.3f;
            big_elec_transform.position = temp - new Vector2(0, count);
            yield return new WaitForSeconds(0.01f);
        }
        big_elec_ready = true;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("1-2Score");
    }
}
