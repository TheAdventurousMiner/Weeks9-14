using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    private float speed = 3f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        Vector3 pulsePosition = Camera.main.WorldToScreenPoint(transform.position);

        if (pulsePosition.x > Screen.width)
        {
            pulsePosition.x = 0;
        }

        transform.position = Camera.main.ScreenToWorldPoint(pulsePosition);

    }
}
