using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtScript : MonoBehaviour
{
    public GameObject fireExt;

    public bool isFloat = true;
    public bool isDragging = false;
    public Vector2 mousePosition;
    Vector2 startPosition;
    Vector2 mouseStartPosition;

    Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isDragging)
        {
            mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 position = mousePosition - mouseStartPosition + startPosition;
            transform.position = position;
        }

        if (transform.position.y <= -2)
        {
            isDragging = false;
            collider.enabled = false;
            isFloat = false;
        }
    }

    private void OnMouseDown()
    {
        if (!isDragging)
        {
            startPosition = transform.position;
            mouseStartPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }
}
