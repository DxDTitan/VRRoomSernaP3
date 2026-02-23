using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    public Light flashLight;
    public AudioSource clickSound;

    public void Flip()
    {
        flashLight.enabled = !flashLight.enabled;
        clickSound.Play();
    }
}