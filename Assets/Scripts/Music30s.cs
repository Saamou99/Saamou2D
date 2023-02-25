using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music30s : MonoBehaviour
{
        public AudioClip audioClip;
        private AudioSource audioSource;
        private float fadeTime = 10f; // time to fade in seconds

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip;
            audioSource.time = 30f;
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
                audioSource.volume = Mathf.Lerp(0f, 0.9f, currentTime / fadeTime);
                yield return null;
            }
            audioSource.volume = 0.9f; // set volume to 100%
        }
}