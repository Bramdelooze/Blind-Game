using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleObject : MonoBehaviour {

    public bool interactable = true;

    private bool colliding;

    public GameObject linkedObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && interactable && colliding)
        {
            if (linkedObject != null)
            {
                print("Interacted with " + gameObject.name);
                linkedObject.gameObject.GetComponent<InteractibleObject>().interactable = true;
                print("Can now interact with " + linkedObject.name);
            }

            Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        colliding = true;
    }
    private void OnTriggerExit(Collider other)
    {
        colliding = false;
    }
}
