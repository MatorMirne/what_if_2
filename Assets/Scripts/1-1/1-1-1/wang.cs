using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wang : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Sprite walk1;
    public Sprite walk2;
    public Sprite seek;
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

        if (transform.position.x < 0.15f)
        {
            spriteRenderer.sprite = seek;
        }
        else Walk();

        if (time> 3.907599f)
        {
            Debug.Log("��1�Ϸ�");
            SceneManager.LoadScene("1-1-2");
        }

    }
    void Walk()
    {
        transform.position = start_position + new Vector2(-time * speed, 0);

        // 1�ʸ��� ��������Ʈ ����
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
