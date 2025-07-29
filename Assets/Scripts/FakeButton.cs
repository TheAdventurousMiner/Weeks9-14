using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeButton : MonoBehaviour
{
    public float hoveringDistance;
    public GameObject triangleObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosiiton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosiiton.z = 0;
            float distanceToTheButton = Vector3.Distance(transform.position, mouseWorldPosiiton);

            if(distanceToTheButton < hoveringDistance)
            {
                Debug.Log("We have clicked the button!");
                triangleObject.SetActive(false);
            }
        }
    }
}
