using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trailPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        trailPosition.z = 0f;
        transform.position = trailPosition;
    }
}
