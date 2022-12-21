using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebApp : PaaS
{
    [Header("WebApp")]
    public int Users;


    void Update()
    {
        if (timer < Time.time)
        {
            cpuUsage = CalculateCpuUsage();
            memoryUsage = CalculateMemoryUsage();
            storageUsage = CalculateStorageUsage();
            timer++;
            Users++;
        }
    }

    public float CalculateCpuUsage()
    {
        return (float)(Random.Range(-0.1f, 0.1f) + 1) * cpuDefault * Users;
    }

    public float CalculateMemoryUsage()
    {
        return (float)(Random.Range(-0.1f, 0.1f) + 1) * memoryDefault * Users;
    }

    public float CalculateStorageUsage()
    {   
        return (float)(stogrageDefault += storageProgressiveUse * Users);
    }
}
