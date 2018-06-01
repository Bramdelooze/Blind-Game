using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectInteraction : MonoBehaviour {

	protected bool objectTriggered;
	public bool inTrigger;
	private bool allowedToTrigger;

	[SerializeField]
	protected float waitTime;

	protected virtual void Start () {
		allowedToTrigger = true;
	}

	protected virtual void Update() { 
		
		if (inTrigger) {
			if (Input.GetKeyDown(KeyCode.F)) {
				StartCoroutine("TriggerObjectCo");
				allowedToTrigger = false;
			}
		}
	}

	IEnumerator TriggerObjectCo() {
		objectTriggered = !objectTriggered;
		yield return new WaitForSeconds(waitTime);
		allowedToTrigger = true;
		inTrigger = false;
	}

}
