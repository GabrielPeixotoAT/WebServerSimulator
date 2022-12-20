using UnityEngine;

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

    [Header ("Storage")]
    [Tooltip ("GB")]
    public float storageCapacity;
    public StorageType storageType;
    [Space(10)]
    [Tooltip("GB")]
    public float storageInUse;

    [Header("Services")]
    public Software[] services;


    void Update()
    {
        float processorUse = 0, memoryUse = 0;

        foreach (Software service in services)
        {
            processorUse += service.cpuUsage;
            memoryUse += service.memoryUsage;
        }

        processorInUse = processorUse;
        memoryInUse = memoryUse;
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
