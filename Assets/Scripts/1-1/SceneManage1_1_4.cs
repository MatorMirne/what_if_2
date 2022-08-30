using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_1_4 : MonoBehaviour
{
    public float timer;

    public bool point1 = false;
    public GameObject str1;
    public GameObject choice1;
    public GameObject choice2;

    

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            FadeOut(str1);
        }

        if (timer > 2)
        {
            FadeIn(choice1);
            FadeIn(choice2);
        }
    }


    void FadeIn(GameObject _gameObject)
    {
        if (_gameObject.activeSelf == false)
        {
            _gameObject.SetActive(true);
            _gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
            StartCoroutine(FadeInCoroutine(_gameObject));
        }
    }

    IEnumerator FadeInCoroutine(GameObject _gameObject)
    {
        float fade_count = 0;
        while (fade_count < 1.0f)
        {
            fade_count += 0.01f;
            yield return new WaitForSeconds(0.01f);
            _gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, fade_count);
        }
    }

    void FadeOut(GameObject _gameObject)
    {
        if (_gameObject.activeSelf == true)
        {
            StartCoroutine(FadeOutCoroutine(_gameObject));
        }
    }

    IEnumerator FadeOutCoroutine(GameObject _gameObject)
    {
        float fade_count =0;
        while (fade_count < 1.0f)
        {
            fade_count += 0.01f;
            yield return new WaitForSeconds(0.01f);
            _gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1.0f - fade_count);
        }
        _gameObject.SetActive(false);
    }
}
