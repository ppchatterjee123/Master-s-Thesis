using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidersound : MonoBehaviour
{
    public AudioSource source;


    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
