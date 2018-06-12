using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAnimation : ObjectInteraction {

	private Animator animator;

	// Use this for initialization
	protected override void Start () {
		animator = GetComponent<Animator>();

		base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {

        animator.SetBool("IsTriggered", base.objectTriggered);
		base.Update();
	}


}
