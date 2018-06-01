using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSound : ObjectInteraction {

	private AudioSource audioSource;

	[SerializeField]
	private AudioClip soundEffect;

	// Use this for initialization
	protected override void Start () {

		audioSource = GetComponent<AudioSource>();

		base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {

		if (base.objectTriggered) {
			Debug.Log("PlaySound");
            PlaySound();
		}

		base.Update();
	}

	void PlaySound () {
		audioSource.clip = soundEffect;
		audioSource.Play();
		base.objectTriggered = false;
	}
}
