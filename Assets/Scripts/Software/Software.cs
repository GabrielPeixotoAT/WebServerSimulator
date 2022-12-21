using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Software : MonoBehaviour
{
    public float cpuUsage, memoryUsage, storageUsage;

    float cpuDefault ,memoryDefault, stogrageDefault, timer;

    void Start()
    {
        cpuDefault = cpuUsage;
        memoryDefault = memoryUsage;
        stogrageDefault = storageUsage;
        timer = Time.time;
    }

    void Update()
    {
        if (timer < Time.time)
        {
            cpuUsage = (float)(Random.Range(-0.1f, 0.1f) + 1) * cpuDefault;
            memoryUsage = (float)(Random.Range(-0.1f, 0.1f) + 1) * memoryDefault;
            storageUsage = (float)(Random.Range(-0.1f, 0.1f) + 1) * stogrageDefault;
            timer++;
        }
    }
}
