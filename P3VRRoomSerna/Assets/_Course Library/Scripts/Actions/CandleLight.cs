using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public ParticleSystem candleFlame;
    private bool isLit = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flame") && !isLit)
        {
            candleFlame.Play();
            isLit = true;
        }
    }
}