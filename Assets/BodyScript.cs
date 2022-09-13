using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyScript : MonoBehaviour
{
    public GameObject speeder;
    public Vector2 offset;
    public bool isFalling = true;

    bool isInPosition = false;
    bool isCollide = false;
    bool isDragging = false;
    Vector2 corPos = new Vector2(0.74f, 3.09f);
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = corPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!speeder.GetComponent<SpeederScript>().isMoving)
        {
            if (isDragging && !isCollide)
            {
                Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position - offset;
                transform.Translate(mousePosition);
            }
        }
        if (isCollide)
        {
            if (!isInPosition)
            {
                isInPosition = true;
                transform.position = corPos;
            }
            gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;

            transform.position = new Vector2(pos.x, pos.y - 0.008f);
            if (pos.y >= 1.22)
            {
                pos = transform.position;
            }
            else
            {
                isFalling = false;
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
        if (collision.tag == "window")
        {
            Debug.Log("collision");
            isCollide = true;
        }
    }
}
