using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetecter : MonoBehaviour {

	MeshRenderer meshRenderer;

    //private Animator fadeAnim;

    private bool animationPlaying;
    private static bool gotKey;
    public GameObject drawerAnimCont;

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

}
