using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class Stick : MonoBehaviour
{

    public string StuckObjectTag = "WallNumber1";
    public GameObject myObject;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(StuckObjectTag))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            myObject.SetActive(true);
        }
    }

}
