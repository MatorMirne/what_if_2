using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage1_2_1 : MonoBehaviour
{
    public GameObject buttonMain, buttonSub1, buttonSub2, buttonSub3;
    public GameObject big_elec;

    bool big_elec_on;
    bool big_elec_ready;

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
    void Update()
    {
        if(!buttonMain.gameObject.GetComponent<ButtonScript>().isOn || !buttonSub1.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub2.gameObject.GetComponent<ButtonScript>().isOn && !buttonSub3.gameObject.GetComponent<ButtonScript>().isOn)
        {
            Debug.Log("elec clear");
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
            count += 0.1f;
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
            count += 0.1f;
            big_elec_transform.position = temp - new Vector2(0, count);
            yield return new WaitForSeconds(0.01f);
        }
        big_elec_ready = true;
    }
}
