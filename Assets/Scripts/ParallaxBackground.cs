using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ParallaxBackground : MonoBehaviour
    {
        [SerializeField] private float parallaxEffectMultiplier;
        private Transform cameraTransform;
        private Vector3 lastCameraPosition;
        private void Start()
        {
            cameraTransform = Camera.main.transform;
            lastCameraPosition = cameraTransform.position;
        }

        private void LateUpdate()
        {
            Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
            float parallaxEffectMultiplier = .5f;
            transform.position += deltaMovement * parallaxEffectMultiplier;
            lastCameraPosition = cameraTransform.position;
        }
    }
}