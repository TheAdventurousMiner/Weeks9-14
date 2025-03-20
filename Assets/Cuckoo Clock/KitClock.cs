using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public float timeAnHourTakes = 5;
    public GameObject bird;
    public float t;
    public int hour = 0;
    int cuckooAmount;

    public UnityEvent<int> OnTheHour;

    Coroutine clockIsRunning;
    IEnumerator doOneHour;

    void Start()
    {
        clockIsRunning = StartCoroutine(MoveTheClock());
    }

    private IEnumerator MoveTheClock()
    {
        while (true)
        {
            doOneHour = MoveTheClockHandOneHour();
            yield return StartCoroutine(doOneHour);
        }
    }

    private IEnumerator MoveTheClockHandOneHour()
    {
        t = 0;
        while (t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        hour++;
        if(hour == 13)
        {
            hour = 1;
        }
        StartCoroutine(PlaySound());
    }

    public void StopTheClock()
    {
        if(clockIsRunning != null)
        {
            StopCoroutine(clockIsRunning);
        }
       
        StopCoroutine(clockIsRunning);
        StopCoroutine(doOneHour);
    }
    public IEnumerator PlaySound()
    {
        cuckooAmount = 0;

        while(cuckooAmount < hour)
        {
            OnTheHour.Invoke(hour);
            bird.SetActive(true);
            yield return new WaitForSeconds(1);
            bird.SetActive(false);
            cuckooAmount += 1;
        }
        cuckooAmount = 0;
    }
}
