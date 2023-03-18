using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float Speed = 5;

    void LateUpdate() 
    {
        transform.position = target.position + offset;

        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += Speed * new Vector3(x:0, y:Input.GetAxis("Mouse X"), z:0);
        }
    }
}
