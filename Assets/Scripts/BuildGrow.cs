using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildGrow : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0f;
    public float maxSize = 1f;
    public float timer;
    public Transform doors;
    public Transform windows;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartBuilding()
    {
        StartCoroutine(Build());
    }

    public IEnumerator Build()
    {
        doors.localScale = Vector3.zero;
        windows.localScale = Vector3.zero;

        timer = 0f;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            transform.localScale = Vector3.one * maxSize * curve.Evaluate(timer);
            yield return null;
        }
        yield return new WaitForSeconds(2f);

        timer = 0f;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            doors.localScale = Vector3.one * maxSize * curve.Evaluate(timer);
            yield return null;
        }

        timer = 0f;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            windows.localScale = Vector3.one * maxSize * curve.Evaluate(timer);
            yield return null;
        }
    }
}
