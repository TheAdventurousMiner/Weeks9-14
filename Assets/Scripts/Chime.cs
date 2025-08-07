using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chime : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayChime(int hour)
    {
        Debug.Log("We are currently chiming on the hour:" + hour.ToString());

        for (int i = 0; i < hour; i++)
        {
            Debug.Log("Chime");
        }

    }
}
