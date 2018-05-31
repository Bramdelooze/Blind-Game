using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimationController : MonoBehaviour {

    public Animator slideAnim;
    public bool slidedOut = false;

    private void OnTriggerStay(Collider other)
    {
        if (!slidedOut && Input.GetKeyDown(KeyCode.F))
        {
            slidedOut = true;
            slideAnim.Play("drawerSlideOut");           
        }
        else if (slidedOut && Input.GetKeyDown(KeyCode.F))
        {
            slidedOut = false;
            slideAnim.Play("drawerSlideIn");
        }
    }
}
