using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class other_car1_6_2 : MonoBehaviour
{
    public float time;

    private bool point1, point2, point3, point4;
    void Start()
    {
        time = 0;
        point1 = true;
        point2 = point3 = point4 = false;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        
            if (time > 1.7f &&point1)
            {
                Debug.Log("point1");
                point1 = false;
                point2 = true;
                StartCoroutine(Move(1.5f, 1f));
            }
        
        else if (time > 5f&&point2)
        {
                Debug.Log("point2");
                point2 = false;
                point3 = true;
                StartCoroutine(Move(-1f, 2f));
           
        }
        else if (time > 7f&&point3)
        { 
                Debug.Log("point3");
                point3 = false;
                point4 = true;
                StartCoroutine(Move(3f, 2f));
            
        }
        else if (time > 9f&&point4)
        {
                Debug.Log("point4");
                point4 = false;
            StartCoroutine(Move(-4f, 2f));

        }
    }

    IEnumerator Move(float move_scale, float time)
    {
        Debug.Log("move");
        float timer = 0;
        float movement = 0;
        Vector2 pos_start = transform.position;
        while (timer < time)
        {
            timer += Time.deltaTime;
            movement = move_scale * (timer / time);
            //Debug.Log(movement);
            transform.position = pos_start + new Vector2(0, movement);

            yield return null; 
        }
        
    }
}
