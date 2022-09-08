using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class mycar1_6_2 : MonoBehaviour//, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject scenemanager;
    public GameObject car1, car2;

    private bool drag;

    void Start()
    {
        drag = false;
    }

    void Update()
    {
        if (Vector2.Distance(car1.transform.position, transform.position) < 3.5f)
        {
            scenemanager.GetComponent<SceneManager1_6_2>().GameOver();
        }

        if (drag)
        {
            Vector2 pos_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            pos_mouse = new Vector2(0, pos_mouse.y);
            transform.Translate(pos_mouse);
        }
    }

    void OnMouseUp()
    {
        drag = false;
    }

    void OnMouseDown()
    {
        drag = true;
    }

}
