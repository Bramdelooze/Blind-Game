using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetecter : MonoBehaviour {

	MeshRenderer meshRenderer;

    //private Animator fadeAnim;

    private bool animationPlaying;
    private static bool gotKey;
    public GameObject drawerAnimCont;
    /*
        // Use this for initialization
        void Start () {
            fadeAnim = gameObject.GetComponent<Animator>();
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.enabled = false;
        }

        IEnumerator ShowMeCo () {

            //fadeAnim.Play("Fade-Out");
            //animationPlaying = true;
            //Color originalCol = meshRenderer.material.GetColor("_Color");
            //Color col = meshRenderer.material.GetColor("_Color");
            //col.a = 0;
            //meshRenderer.material.color = Color.Lerp(originalCol, col, Time.deltaTime);
            yield return new WaitForSeconds(.5f);
            meshRenderer.enabled = false;

        }

        void OnTriggerEnter(Collider other)
        {
               //StopCoroutine("ShowMeCo");
               //if (animationPlaying)
               //{
               //    fadeAnim.Play("Idle");
               //    animationPlaying = false;
               //}
                Color32 col = meshRenderer.material.GetColor("_Color");
                col.a = 100;
                meshRenderer.material.SetColor("_Color", col);
                meshRenderer.enabled = true;
        }
        */
    private void OnTriggerStay(Collider other)
    {
        if(gameObject.name == "Key" && Input.GetKeyDown(KeyCode.Mouse0) && drawerAnimCont.GetComponent<DrawerAnimationController>().slidedOut)
        {
            gotKey = true;
            Destroy(gameObject);
        }
        if(gameObject.name == "Deur_4" && gotKey && Input.GetKeyDown(KeyCode.F))
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
    /*
    private void OnTriggerExit(Collider other)
    {
        StartCoroutine("ShowMeCo");
    }
    */
}
