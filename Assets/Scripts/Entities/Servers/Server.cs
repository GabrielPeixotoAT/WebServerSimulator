using UnityEngine;

public class Server : MonoBehaviour
{
    [Header ("Processor")]
    [Tooltip ("MHz")]
    public float processorFrequency;
    [Tooltip ("KB")]
    public float processorCache;
    [Tooltip ("C°")]
    public float processorTemperature;

    [Header ("Memory")]
    [Tooltip ("MB")]
    public int memoryCapacity;
    [Tooltip("MHz")]
    public float memoryFrequency;

    [Header ("Storage")]
    [Tooltip ("GB")]
    public int storageCapacity;
    public StorageType storageType;

    public void UpgradeProcessor(float processorFrequency, float processorCache)
    {
        this.processorFrequency = processorFrequency;
        this.processorCache = processorCache;
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
