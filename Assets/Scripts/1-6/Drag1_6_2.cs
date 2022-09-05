using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag1_6_2 : MonoBehaviour, IDragHandler
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    void IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        Debug.Log("µå·¡±×");
    }


}
