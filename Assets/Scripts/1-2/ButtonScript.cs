using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Sprite buttonOn, buttonOff;
    SpriteRenderer spriteRenderer;
    public bool isOn = true;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        if(isOn)
        {
            spriteRenderer.sprite = buttonOff;
            isOn = false;
        }
        else
        {
            spriteRenderer.sprite = buttonOn;
            isOn = true;
        }
    }
}