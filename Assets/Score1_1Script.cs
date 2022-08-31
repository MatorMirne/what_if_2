using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score1_1Script : MonoBehaviour
{
    public Sprite good, bad;
    SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(ManagerScript.chapter1_1repeat_num == 0)
        {
            spriteRenderer.sprite = good;
        }
        else
        {
            spriteRenderer.sprite = bad;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
