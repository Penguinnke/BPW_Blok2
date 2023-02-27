using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class Stick : MonoBehaviour //Make the blocks you have to push on the platforms stick
{

    public string StuckObjectTag = "WallNumber1"; 
    public GameObject myObject;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(StuckObjectTag))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Block touched the plate");
            myObject.SetActive(true);
        }
    }

}
