using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mycar1_6_2 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject scenemanager;
    public GameObject car1, car2;

    Vector2 pos_start;



    void Start()
    {
        
    }

    void Update()
    {
        if (Vector2.Distance(car1.transform.position, transform.position) < 3.5f)
        {
            scenemanager.GetComponent<SceneManager1_6_2>().GameOver();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("드래그");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("드래깅");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("드래끝");
    }
}
