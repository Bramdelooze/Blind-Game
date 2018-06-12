using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectInteraction : MonoBehaviour {

	protected bool objectTriggered;
	public bool inTrigger;
	private bool allowedToTrigger;

    [SerializeField]
    private GameObject linkedObject;

    public bool interactable = true;

	[SerializeField]
	protected float waitTime;

	protected virtual void Start () {
		allowedToTrigger = true;
	}

	protected virtual void Update() { 
		
		if (inTrigger) {
			if (Input.GetKeyDown(KeyCode.F) && interactable) {
                if (linkedObject != null)
                {
                    print("Interacted with " + gameObject.name);
                    linkedObject.gameObject.GetComponent<ObjectInteraction>().interactable = true;
                    print("Can now interact with " + linkedObject.name);
                }
                //StartCoroutine("TriggerObjectCo");
				//allowedToTrigger = false;
			}
		}
	}

    private void LateUpdate()
    {
        inTrigger = false;
    }

    //IEnumerator TriggerObjectCo() {
    //	objectTriggered = !objectTriggered;
    //	yield return new WaitForSeconds(waitTime);
    //	allowedToTrigger = true;
    //	inTrigger = false;
    //}

}
