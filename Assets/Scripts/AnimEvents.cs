using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    AudioSource audioSource; // cache -> audio source

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnFootsteps()
    {
        //Debug.Log("Footstep");
        audioSource.Play();
    }
}
