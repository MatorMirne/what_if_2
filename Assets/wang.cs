using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wang : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Sprite walk1;
    public Sprite walk2;
    public float speed;

    Vector2 start_position;
    public float time = 0;
    float timer = 0;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        start_position = transform.position;
    }

    private void Update()
    {
        time += Time.deltaTime;
        timer += Time.deltaTime*speed;

        transform.position = start_position + new Vector2(-time* speed, 0);

        // 1초마다 스프라이트 변경
        if (0<=timer && timer<1)
        {
            spriteRenderer.sprite = walk1;
        }
        else{
            spriteRenderer.sprite = walk2;
            if (timer > 2)
            {
                timer = 0;
            }
        }

        if (transform.position.x < -3.81f)
        {
            Debug.Log("씬1완료");
            SceneManager.LoadScene("1-1-2");
        }
    }
}
