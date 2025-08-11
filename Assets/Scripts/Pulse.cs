using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (transform.position.x > Screen.width)
        {
            Vector3 newPosition = new Vector3(0f, transform.position.y, 0f);
            transform.position = newPosition;
        }
    }
}
