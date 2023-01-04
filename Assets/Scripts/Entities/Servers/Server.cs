using UnityEngine;
using Assets.Scripts.Software;
using Assets.Scripts.Software.IaaS;
using Assets.Scripts.Software.PaaS;

public class Server : MonoBehaviour
{
    [Header ("Processor")]
    [Tooltip ("MHz")]
    public float processorFrequency;
    public int processorCores;
    [Tooltip("KB")]
    public float processorCache;
    [Space(10)]
    [Tooltip("MHz")]
    public float processorInUse;
    public float processorPercentage;
    [Tooltip ("C°")]
    public float processorTemperature;

    [Header ("Memory")]
    [Tooltip ("MB")]
    public int memoryCapacity;
    [Tooltip("MHz")]
    public float memoryFrequency;
    [Space(10)]
    [Tooltip("MB")]
    public float memoryInUse;
    public float memoryPercentage;

    [Header ("Storage")]
    [Tooltip ("GB")]
    public float storageCapacity;
    public StorageType storageType;
    [Space(10)]
    [Tooltip("GB")]
    public float storageInUse;
    public float storagePercentage;

    [Header("Services")]
    public Software[] services;
    public int TotalUsers;

    [Header("OS Installed")]
    public OperatingSystem operatingSystem;


    void Update()
    {
        float processorUse = 0, memoryUse = 0, storageUse = 0, totalUsers = 0;

        foreach (Software service in services)
        {
            processorUse += service.cpuUsage;
            memoryUse += service.memoryUsage;
            storageUse += service.storageUsage;
            WebApp webApp = service as WebApp;
            totalUsers += webApp.Users;
        }

        processorInUse = processorUse + operatingSystem.cpuUsage;
        memoryInUse = memoryUse + operatingSystem.memoryUsage;
        storageInUse = storageUse + operatingSystem.storageUsage;
        TotalUsers = (int) totalUsers;

        processorPercentage = processorInUse * 100 / (processorFrequency * processorCores);
        memoryPercentage = memoryInUse * 100 / memoryCapacity;
        storagePercentage = storageInUse * 100 / storageCapacity;
    }

    public void UpgradeProcessor(float processorFrequency, float processorCache, int processorCores)
    {
        this.processorFrequency = processorFrequency;
        this.processorCache = processorCache;
        this.processorCores = processorCores;
    }

    public void UpgradeMemory(int memoryCapacity, float memoryFrequency)
    {
        this.memoryCapacity = memoryCapacity;
        this.memoryFrequency = memoryFrequency;
    }

    public void UpgradeStorage(int storageCapacity, StorageType storageType)
    {
        this.storageCapacity = storageCapacity;
        this.storageType = storageType;
    }


}
