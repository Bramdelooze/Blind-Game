using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetecter : MonoBehaviour {

	MeshRenderer meshRenderer;

    private Animator fadeAnim;

    private bool animationPlaying;
    private static bool gotKey;

	// Use this for initialization
	void Start () {
        fadeAnim = gameObject.GetComponent<Animator>();
		meshRenderer = GetComponent<MeshRenderer>();
		meshRenderer.enabled = false;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ShowMeCo () {

        fadeAnim.Play("Fade-Out");
        animationPlaying = true;
        yield return new WaitForSeconds(.5f);
        meshRenderer.enabled = false;

	}

	void OnTriggerEnter(Collider other)
	{
            StopCoroutine("ShowMeCo");
            if (animationPlaying)
            {
                fadeAnim.Play("Idle");
                animationPlaying = false;
            }
            Color32 col = meshRenderer.material.GetColor("_Color");
            col.a = 100;
            meshRenderer.material.SetColor("_Color", col);
            meshRenderer.enabled = true;
	}
    private void OnTriggerStay(Collider other)
    {
        if(gameObject.name == "Key" && Input.GetKeyDown(KeyCode.F))
        {
            gotKey = true;
            Destroy(gameObject);
        }
        if(gameObject.name == "Door" && gotKey && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Open Door");
            Destroy(gameObject);
        }
        if(gameObject.name == "White Noise Picture" && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Tv Uit");
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        StartCoroutine("ShowMeCo");
    }
}
