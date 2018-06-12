using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeFluent : MonoBehaviour {

	MeshRenderer meshRenderer;

	private bool isColliding;
	private bool isFading;

	private Color thisColor;
	private float alphaValue;
	private float transparency;

	[SerializeField]
	private float speed;

	// Use this for initialization
	private void Start()
	{
		meshRenderer = GetComponent<MeshRenderer>();
		meshRenderer.enabled = true;
	}

	// Update is called once per frame
	private void Update()
	{
		// Check current color and set alpha to transparency
		meshRenderer.material.color = thisColor;
		thisColor = meshRenderer.material.color;
		thisColor.a = transparency;

		if (isColliding)
		{
			FadeIn();
		}
		else {
			FadeOut();
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		isColliding = true;
	}

	private void OnTriggerExit(Collider other)
	{
		isColliding = false;
	}

	private void FadeIn() 
	{
		meshRenderer.enabled = true;
		isFading = true;
		transparency = alphaValue;

		if (alphaValue <= 1 && isFading) {
			alphaValue += speed * Time.deltaTime;
		} else {
			isFading = false;
		}
	}

	private void FadeOut() 
	{
		isFading = true;
		transparency = alphaValue;

		if (alphaValue >= 0 && isFading) {
			alphaValue -= speed * Time.deltaTime;
		} else {
			isFading = false;
			meshRenderer.enabled = false;
		}
	}
}
