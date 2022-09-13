using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyScript : MonoBehaviour
{
    public GameObject speeder;
    public Vector2 offset;

    bool isCollide = false;
    bool isDragging = false;
    Vector2 corPos = new Vector2(1.97f, 3.09f);

    // Start is called before the first frame update
    void Start()
    {
        
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
            gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
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
            transform.position = corPos;
        }
    }
}
