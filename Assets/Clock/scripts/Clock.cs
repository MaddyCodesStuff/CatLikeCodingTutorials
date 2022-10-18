using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    const float hoursToDegree = -30f, minutesToDegree = -6f, secondsToDegree =-6f;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f,0f, hoursToDegree* (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f, minutesToDegree * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f, secondsToDegree * (float)time.TotalSeconds);
    }
}
