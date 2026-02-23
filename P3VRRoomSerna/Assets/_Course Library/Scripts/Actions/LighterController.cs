using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterController : MonoBehaviour
{
    public ParticleSystem flame;

    public void ToggleFlame()
    {
        if (flame.isPlaying)
            flame.Stop();
        else
            flame.Play();
    }
}