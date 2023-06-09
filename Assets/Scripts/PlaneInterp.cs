using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneInterp : MonoBehaviour
{
     public Transform startPos;  // Starting position
        public Transform endPos;    // Ending position
        public float speed = 5f;    // Movement speed
        
        public bool light;
        public bool medium;
        public bool heavy;
    
        private float startTime;
        private float journeyLength;
    
        private void Start()
        {
            startTime = Time.time;
            journeyLength = Vector3.Distance(startPos.position, endPos.position);
        }
    
        private void Update()
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distanceCovered / journeyLength;
    
            transform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJourney);
    
            if (fractionOfJourney >= 1f)
            {
                Destroy(gameObject);
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "crack")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                rend.enabled = true;
            }
        }
}
