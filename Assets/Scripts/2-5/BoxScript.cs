using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject boxOpen, belt, speeder, body;
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
        //  GetComponent<SpriteRenderer>().enabled = false;

        boxOpen.SetActive(true);
        belt.SetActive(true);
        speeder.SetActive(true);
        body.SetActive(true);

        gameObject.SetActive(false);
    }
}
