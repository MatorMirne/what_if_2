using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtScript : MonoBehaviour
{
    public GameObject fireExt;

    public bool isFloat = true;
    public bool isDragging = false;
    public Vector2 offset;
    public Vector2 mousePosition;

    Vector2 pos;
    Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position + offset;
            transform.Translate(mousePosition);
            pos = transform.position;
        }

        if (pos.y <= -2)
        {
            isDragging = false;
            collider.enabled = false;
            isFloat = false;
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
}
