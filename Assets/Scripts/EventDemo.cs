using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent OnTimerHasFinish;
    public float timerLength = 3;
    public float t;

    public void MouseJustEnteredImage()
    {
        Debug.Log("The mouse just entered the image!");
        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustLeftImage()
    {
        Debug.Log("The mouse just left the image!");
        banana.localScale = Vector3.one;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            OnTimerHasFinish.Invoke();
            t = 0;
        }
    }
}
