using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Software : MonoBehaviour
{
    [Header("Use of Service Resources")]
    public float cpuUsage, memoryUsage, storageUsage;

    public float cpuDefault ,memoryDefault, stogrageDefault, timer;

    public float storageProgressiveUse;

    void Start()
    {
        cpuDefault = cpuUsage;
        memoryDefault = memoryUsage;
        stogrageDefault = storageUsage;
        storageProgressiveUse = 0.0001f;
        timer = Time.time;
    }

    void Update()
    {
        if (timer < Time.time)
        {
            cpuUsage = CalculateCpuUsage();
            memoryUsage = CalculateMemoryUsage();
            storageUsage = CalculateStorageUsage();
            timer++;
        }
    }

    public float CalculateCpuUsage()
    {
        return (float) (Random.Range(-0.1f, 0.1f) + 1) * cpuDefault;
    }

    public float CalculateMemoryUsage(float users = 1)
    {
        return (float)(Random.Range(-0.1f, 0.1f) + 1) * memoryDefault * users;
    }

    public float CalculateStorageUsage(float users = 1)
    {
        return (float)(stogrageDefault += storageProgressiveUse) * users;
    }

}
