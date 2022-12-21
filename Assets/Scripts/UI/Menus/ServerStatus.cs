using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ServerStatus : MonoBehaviour
{
    [Header("Server")]
    public Server server;

    [Header("UI Ellements")]
    public Image cpuBar;
    public TMP_Text cpuText;
    public Image memoryBar;
    public TMP_Text memoryText;
    public Image storageBar;
    public TMP_Text storageText;


    // Update is called once per frame
    void Update()
    {
        cpuBar.fillAmount = server.processorPercentage / 100;
        cpuText.text = server.processorPercentage.ToString("F0") + "%";
        memoryBar.fillAmount = server.memoryPercentage / 100;
        memoryText.text = server.memoryPercentage.ToString("F0") + "%";
        storageBar.fillAmount = server.storagePercentage / 100;
        storageText.text = server.storagePercentage.ToString("F0") + "%";
    }
}
