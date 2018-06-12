using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectInteraction : MonoBehaviour {

	protected bool objectTriggered;
	public bool inTrigger;

    [SerializeField]
	private ObjectInteraction linkedObject;

	// Only allow to trigger animation or sound if interactable is true
    public bool interactable = true;

	[SerializeField]
	protected float triggerAgainWaitTime;

	protected virtual void Start () 
	{
		
	}

	protected virtual void Update() 
	{ 
		if (inTrigger) {
			if (Input.GetKeyDown(KeyCode.F) && interactable) {
				ActivateLinkedObject();
				StartCoroutine("TriggerObjectCo");
			}
		}
	}

    private void LateUpdate()
    {
        inTrigger = false;
    }

	protected void ActivateLinkedObject() 
	{ 
		if (linkedObject != null)
        {
        	print("Interacted with " + gameObject.name);
			linkedObject.interactable = true;
			print("Can now interact with " + linkedObject.name);
        }
	
	}

	private IEnumerator TriggerObjectCo() {
		
		objectTriggered = !objectTriggered;
		yield return new WaitForSeconds(triggerAgainWaitTime);
		//allowedToTrigger = true;
		inTrigger = false;
	}

}
