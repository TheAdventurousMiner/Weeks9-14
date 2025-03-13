using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChimeTimer : MonoBehaviour
{
    public UnityEvent ChimeTime;
    public float timer = 2;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > timer)
        {
            ChimeTime.Invoke();
            t = 0;
        }
    }
}
