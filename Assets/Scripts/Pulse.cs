using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    private float speed = 10f;
    public AnimationCurve pulseCurve;
    private float timePassed;
  
    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        timePassed += Time.deltaTime;

        Vector3 pulsePosition = Camera.main.WorldToScreenPoint(transform.position);

        if (pulsePosition.x > Screen.width)
        {
            pulsePosition.x = 0;
            timePassed = 0f;
        }

        float yCurve = pulseCurve.Evaluate(timePassed);

        Vector3 newPosition = Camera.main.ScreenToWorldPoint(pulsePosition);

        transform.position = new Vector3(newPosition.x , yCurve, 0f);

       

    }
}
