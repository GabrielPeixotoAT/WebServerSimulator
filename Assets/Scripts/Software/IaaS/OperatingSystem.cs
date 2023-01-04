using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Software.IaaS
{
    public class OperatingSystem : MonoBehaviour
    {
        [Header("Operating System")]
        public string osName;

        [Header("Use of Service Resources")]
        public float cpuUsage;
        public float memoryUsage;
        public float storageUsage;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

