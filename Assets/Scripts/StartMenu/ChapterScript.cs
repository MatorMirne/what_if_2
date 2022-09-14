using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterScript : SceneBase
{
    public GameObject all;
    private void OnMouseDown()
    {
        FadeOut(all);
        StartCoroutine(WaitThis());
    }

    IEnumerator WaitThis()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("2-1-1");
    }
}
