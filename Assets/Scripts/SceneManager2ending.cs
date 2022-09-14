using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2ending : SceneBase
{
    public GameObject a, b;

    void Start()
    {        
        StartCoroutine(go());
    }



    IEnumerator go()
    {
        yield return new WaitForSeconds(1f);
        FadeIn(a);
        yield return new WaitForSeconds(4f);
        FadeOut(a);
        yield return new WaitForSeconds(2f);
        FadeIn(b);
        yield return new WaitForSeconds(4f);
        FadeOut(b);

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Chapter2Score");
    }
}
