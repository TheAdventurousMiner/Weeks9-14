using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightController : MonoBehaviour
{
    public UnityEvent lightStop;
    public UnityEvent lightGo;
    SpriteRenderer lightRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lightRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            lightStop.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
         
            lightGo.Invoke();
        }
    }
    public void stopLight()
    {
        Debug.Log("Stop!");
        lightRenderer.color = Color.red;
    }
    public void goLight()
    {
        Debug.Log("Go!");
        lightRenderer.color = Color.green;
    }
}
