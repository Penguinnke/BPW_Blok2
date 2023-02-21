using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Karakter kon de boxjes niet goed duwen maar door een script te maken die ervoor zorgt dat het karakter component een "force of collision" aan het object geeft

public class CharacterPush : MonoBehaviour
{

    [SerializeField]
    private float forceMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (rigidbody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 2;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);
        }
        
    }
}
