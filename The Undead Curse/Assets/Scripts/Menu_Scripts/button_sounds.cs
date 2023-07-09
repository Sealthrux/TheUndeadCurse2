using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_sounds : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    /*
    public AudioClip hoverSound;
    */
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

    /*
    public void HoverSound()
    {
        myFx.PlayOneShot(hoverSound);
    }
    */
}
