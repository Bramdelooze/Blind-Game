using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractItem : ObjectInteraction {

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (!base.interactable)
        {
            gameObject.GetComponent<Collider>().enabled = false;
        } else
        {
            gameObject.GetComponent<Collider>().enabled = true;
        }

        if (base.inTrigger && base.interactable && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
        base.Update();
    }
}
