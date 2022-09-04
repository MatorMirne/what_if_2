using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wang1_5_2 : MonoBehaviour
{
    public GameObject scenemanager;
    public Sprite walk1, walk2;
    public Sprite hole, elec;

    Vector2 startpos;
    Vector2 move;
    //Vector2 dead_pos;

    float time;
    float walk_time;
    bool dead;

    private void Start()
    {
        startpos = transform.position;
        move = new Vector2(0, 0);
        dead = false;
    }

    private void Update()
    {
        time += Time.deltaTime;
        walk_time += Time.deltaTime;
        if (!dead)
        {
            Walk();
        }
        else
        {
            //transform.position = dead_pos;
        }

        if(transform.position.y > 6f)
        {
            ManagerScript.data_1_5 = 0;

            scenemanager.GetComponent<SceneManager1_5_2>().GameOver();
        }
    }

    void Walk()
    {
        //Debug.Log("walk");
        transform.position = startpos + new Vector2(0, time) + move;
        if (walk_time > 0.5f)
        {
            walk_time = 0;
            Image_Change();
        }
    }

    void Image_Change()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == walk1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = walk2;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = walk1;
        }
    }

    public void Move_Right()
    {
        if (move.x < 2)
        {
            move += new Vector2(1, 0);
        }
    }

    public void Move_Left()
    {
        if (move.x > -2)
        {
            move += new Vector2(-1, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hole")
        {
            if (dead == false)
            {
                dead = true;
                gameObject.GetComponent<SpriteRenderer>().sprite = hole;
                //dead_pos = transform.position;
                ManagerScript.data_1_5 = 1;

                StartCoroutine(GameOver());
            }
        }
        else if (other.tag == "street_light" || other.tag == "traffic_light")
        {
            if (dead == false)
            {
                dead = true;
                gameObject.GetComponent<SpriteRenderer>().sprite = elec;
                //dead_pos = transform.position;
                ManagerScript.data_1_5 = 2;
                StartCoroutine(GameOver());
            }
        }

        IEnumerator GameOver()
        {
            float game_over_timer = 0;

            while (game_over_timer < 1f)
            {
                game_over_timer += 0.01f;
                yield return new WaitForSeconds(0.01f);
            }

            scenemanager.GetComponent<SceneManager1_5_2>().GameOver();
        }
        
    }
}
