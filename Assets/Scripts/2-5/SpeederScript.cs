using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederScript : MonoBehaviour
{
    public Sprite speeder1, speeder2, speeder3, speeder4;
    public GameObject body, belt, speeder;
    public bool isMoving = true;

    SpriteRenderer spriteRenderer;

    bool isDragging = false;
    bool isCollide = false;
    bool isInPlace = false;
    public Vector2 offset;
    Vector2 corPos = new Vector2(-0.39f, 4.44f);
    Vector2 bodyOffset, beltOffset;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        body.GetComponent<PolygonCollider2D>().enabled = false;

        bodyOffset = transform.position - body.transform.position;
        beltOffset = transform.position - belt.transform.position;

        spriteRenderer = speeder.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isInPlace)
        {
            body.transform.position = (Vector2)transform.position - bodyOffset;
            belt.transform.position = (Vector2)transform.position - beltOffset;
            if (isCollide)
            {
                isInPlace = true;
            }
        }

        if (isDragging && !isCollide)
        {
            Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position - offset;
            transform.Translate(mousePosition);
        }

        if (isInPlace)
        {
            timer += Time.deltaTime;

            if(timer > 3)
            {
                spriteRenderer.sprite = speeder4;
                body.GetComponent<PolygonCollider2D>().enabled = true;
                isMoving = false;
            }
            else if(timer > 2)
            {
                spriteRenderer.sprite = speeder3;
            }
            else if(timer > 1)
            {
                spriteRenderer.sprite = speeder2;
            }
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging=false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "descender")
        {
            isCollide = true;
            transform.position = corPos;
        }
    }
}
