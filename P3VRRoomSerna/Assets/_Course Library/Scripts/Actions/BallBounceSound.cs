using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    
    public AudioSource audioSource;
    public AudioClip bounceSound;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            float volume = Mathf.Clamp(rb.velocity.magnitude / 10f, 0.2f, 1f);
            audioSource.PlayOneShot(bounceSound, volume);
        }
    }
}