using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music5 : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    private float fadeTime = 15f; // time to fade in seconds

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.time = 1f;
        audioSource.volume = 0f; // set volume to 0%
        audioSource.Play();

        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float currentTime = 0f;

        while (currentTime < fadeTime)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0f, 1f, currentTime / fadeTime);
            yield return null;
        }
        audioSource.volume = 1f; // set volume to 100%
    }
}
