using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    public Sprite windowClosed, windowOpened;
    SpriteRenderer spriteRenderer;
    public bool isOpen = true;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (isOpen)
        {
            spriteRenderer.sprite = windowClosed;
            isOpen = false;
        }
        else
        {
            spriteRenderer.sprite = windowOpened;
            isOpen = true;
        }
    }
}
