using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cigarOffScript : MonoBehaviour
{
    public GameObject trashCan, lightOff;

    bool isDragging = false;
    public Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            lightOff.SetActive(false);
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
