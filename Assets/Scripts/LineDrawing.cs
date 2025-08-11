using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawing : MonoBehaviour
{
    public LineRenderer lineRenderer;

    public float holdToRemoveDuration;

    private float timeHoldingDownMouse = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 positionToAdd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            positionToAdd.z = 0f;

            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, positionToAdd);
        }
        if(Input.GetMouseButtonDown(1))
        {
            timeHoldingDownMouse += Time.deltaTime;
            Debug.Log("Time holding down mouse[" + timeHoldingDownMouse.ToString() + "]");
            if (lineRenderer.positionCount != 0 && timeHoldingDownMouse > holdToRemoveDuration)
            {
                lineRenderer.positionCount--;
                timeHoldingDownMouse = 0f;
            }

        }
        else if(Input.GetMouseButtonUp(1))
        {
            timeHoldingDownMouse = 0f;
            Debug.Log("Resetting the time.");
        }
    }
}
