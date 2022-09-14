using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlug : MonoBehaviour
{
    public bool isUp = false;

    public Sprite plugUp;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    private void OnMouseDown()
    {
        isUp = true;
        spriteRenderer.sprite = plugUp;
    }
}
