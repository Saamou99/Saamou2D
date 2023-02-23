using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music30s : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    private float fadeTime = 10f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.time = 30f; // Set the playback position to 30 seconds
        audioSource.volume = 0f;
        audioSource.Play();

        StartCoroutine(FadeIn());    
    }

IEnumerator FadeIn()
{
    float currentTime = 0f;
    
    while (currentTime < fadeTime)
    {
        currentTime += Time.deltaTime;
        audioSource.volume = Mathf.Lerp(0f, 0.9f, currentTime / fadeTime);
        yield return null;
    }
    audioSource.volume = 0.9f;
}

}