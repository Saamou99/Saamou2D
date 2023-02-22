using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music30s : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.time = 30f; // Set the playback position to 30 seconds
        audioSource.Play();
    }
}