using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlug : MonoBehaviour
{
    public Sprite plugUp;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        spriteRenderer.sprite = plugUp;
    }
}
