using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float Speed = 5;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += Speed * new Vector3(x:0, y:Input.GetAxis("Mouse X"), z:0);
        }
    }
}
