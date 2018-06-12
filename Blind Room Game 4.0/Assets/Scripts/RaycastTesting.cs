using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTesting : MonoBehaviour {

	public float maxRayDistance;
	public LayerMask activeLayers;

	void FixedUpdate() {
		
		// Shoot a ray from a Vector to a direction, check for hit and draw line
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		Debug.DrawLine(transform.position, transform.position + transform.forward * maxRayDistance, Color.red);

		// Check if the ray hits object with the right layer
		if (Physics.Raycast(ray, out hit, maxRayDistance, activeLayers))
		{
			hit.transform.gameObject.GetComponent<ObjectInteraction>().inTrigger = true;
			Debug.DrawLine(hit.point, hit.point + Vector3.up * 5, Color.green);
			Debug.Log("hit");
		}

	}

}
