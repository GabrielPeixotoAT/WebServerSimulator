using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Mouse X") / 100, Input.GetAxis("Mouse Y") / 100, 0));
    }
}
