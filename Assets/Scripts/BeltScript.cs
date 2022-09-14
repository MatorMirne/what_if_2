using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeltScript : SceneBase
{
    public GameObject wangNormal, wangBelt, body, fadeSprite;
    public Vector2 offset;

    bool isDragging = false;
    bool isCollide = false;
    float timer = 0;

    


    void Update()
    {
        if (!body.GetComponent<BodyScript>().isFalling)
        {
            if (isDragging)
            {
                Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position - offset;
                transform.Translate(mousePosition);
            }
            if (isCollide)
            {
                wangNormal.SetActive(false);
                wangBelt.SetActive(true);
                GetComponent<SpriteRenderer>().enabled = false;

                timer += Time.deltaTime;

                if(timer > 3)
                {
                    //  ´ÙÀ½ ¾ÀÀ¸·Î
                    SceneManager.LoadScene("2-5-3");
                }
                else if(timer > 1.5)
                {
                    FadeIn(fadeSprite);
                }
            }
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }
    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCollide = true;
        }
    }
}
