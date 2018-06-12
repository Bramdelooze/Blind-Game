using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTesting : MonoBehaviour {

	public float maxRayDistance;
	public LayerMask activeLayers;
    public GameObject raycastedObject;

    private void Start()
    {
		raycastedObject = new GameObject();
    }

    private void FixedUpdate() 
	{
		// Shoot a ray from a Vector to a direction, check for hit and draw line
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;

        // Check if the ray hits object with the right layer
        if (Physics.Raycast(ray, out hit, maxRayDistance, activeLayers))
        {
			raycastedObject = hit.transform.gameObject;
			raycastedObject.GetComponent<ObjectInteraction>().inTrigger = true;
            Debug.DrawLine(hit.point, hit.point + Vector3.up * 5, Color.green);
        }
	}

}
