using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    private float speed = 10f;
    public AnimationCurve pulseCurve;
    private float timePassed;

    public TrailRenderer trailRenderer;
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
            StartCoroutine(resetPulse(pulsePosition));
        }

        float yCurve = pulseCurve.Evaluate(timePassed);

        Vector3 newPosition = Camera.main.ScreenToWorldPoint(pulsePosition);

        transform.position = new Vector3(newPosition.x , yCurve, 0f);

    }
    private IEnumerator resetPulse(Vector3 pulsePosition)
    {
        trailRenderer.emitting = false;
        yield return new WaitForSeconds(0.1f);

        pulsePosition.x = 0;
        timePassed = 0f;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(pulsePosition);
        transform.position = new Vector3(worldPosition.x, pulseCurve.Evaluate(timePassed), 0f);
        yield return null;
        trailRenderer.emitting = true;
    }

}
