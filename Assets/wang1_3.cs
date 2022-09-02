using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wang1_3 : MonoBehaviour
{
    public Sprite idle, calling;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        StartCoroutine(MotionDelay());
    }

    IEnumerator MotionDelay()
    {
        spriteRenderer.sprite = calling;
        yield return new WaitForSeconds(4f);
        spriteRenderer.sprite = idle;
    }
}
