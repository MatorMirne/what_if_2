using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cigarOffScript : MonoBehaviour
{
    public GameObject trashCan, lightOff;
    public string next_scene;

    bool isDragging = false;
    public Vector2 offset;

    void FixedUpdate()
    {
        if (isDragging)
        {
            Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position - offset;
            transform.Translate(mousePosition);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("success!");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        StartCoroutine(NextScene(2));
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }
    private void OnMouseUp()
    {
        isDragging = false;
    }

    IEnumerator NextScene(float deadline)
    {
        
            yield return new WaitForSeconds(deadline);
        
        SceneManager.LoadScene(next_scene);
    }
}
