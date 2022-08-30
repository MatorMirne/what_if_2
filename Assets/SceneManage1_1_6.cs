using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage1_1_6 : MonoBehaviour
{
    //Timepoint
    public bool point1;
    public bool point2;


    // WANG
    public GameObject wang;
    SpriteRenderer spriteRenderer;
    Transform wang_transform;

    public Sprite walk1;
    public Sprite walk2;
    public float speed;

    Vector2 start_position;
    public float time = 0;
    float timer = 0;

    private void Awake()
    {
        point1 = true;

        // WANG
        spriteRenderer = wang.GetComponent<SpriteRenderer>();
        wang_transform = wang.GetComponent<Transform>();

        start_position = transform.position;
    }

    private void Update()
    {
        timer += Time.deltaTime * speed;
        time += Time.deltaTime;

        if (time > 1.5f && point1)
        {
            time = 0;
            point1 = false;
            wang_transform.localScale = new Vector2(-1, 1) * wang_transform.localScale;
            point2 = true;
        }

        if (point2)
        {
            Walk();
        }

        if (wang_transform.position.x> 3.93)
        {
            SceneManager.LoadScene("1-2-1");
        }

    }
    void Walk()
    {
        wang_transform.position = new Vector2(-0.78f, 0) + start_position + new Vector2((time) * speed, 0);

        // 1초마다 스프라이트 변경
        if (0 <= timer && timer < 1)
        {
            spriteRenderer.sprite = walk1;
        }
        else
        {
            spriteRenderer.sprite = walk2;
            if (timer > 2)
            {
                timer = 0;
            }
        }
    }
}
