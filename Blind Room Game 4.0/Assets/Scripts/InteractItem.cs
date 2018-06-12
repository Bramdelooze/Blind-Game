using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractItem : ObjectInteraction {

	private Collider myCollider;

    // Use this for initialization
    protected override void Start()
    {
		myCollider = GetComponent<Collider>();

        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (!base.interactable)
        {
			myCollider.enabled = false;
        } else
        {
			myCollider.enabled = true;
        }

        if (base.interactable && Input.GetKeyDown(KeyCode.F))
        {
			base.ActivateLinkedObject();
			Destroy(gameObject);	
        }

        base.Update();
    }
}
