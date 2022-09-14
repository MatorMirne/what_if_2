using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBase : MonoBehaviour
{
    protected void FadeIn(GameObject _gameObject)
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
        float time = 0;
        while (time < 1.0f)
        {
            time += Time.deltaTime;
            yield return null;
            _gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, time);
        }
    }

    // [주의사항] FadeOut이 여러 번 실행되지 않도록 주의해 주세요!
    protected void FadeOut(GameObject _gameObject)
    {
        if (_gameObject.activeSelf == true)
        {
            StartCoroutine(FadeOutCoroutine(_gameObject));
        }
    }

    IEnumerator FadeOutCoroutine(GameObject _gameObject)
    {
        float time = 0;
        while (time < 1.0f)
        {
            time += Time.deltaTime;
            yield return null;
            _gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1.0f - time);
        }
        _gameObject.SetActive(false);
    }
}
