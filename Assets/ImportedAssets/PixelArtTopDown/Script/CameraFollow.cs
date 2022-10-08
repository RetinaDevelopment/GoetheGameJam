﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float lerpSpeed = 100f;
        private Vector3 offset;
        private Vector3 targetPos;

        private void Start()
        {
            if (target == null) return;
            offset = transform.position - target.position;
        }

        private void FixedUpdate()
        {
            if (target == null) return;
            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
        }

    }
}
