using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MoveEm : MonoBehaviour
{
    public GameObject BoomBoom;
    public AudioSource explosionSFX;


    public void MoveEmNow(Transform pos)
    {
        BoomBoom.transform.position = pos.transform.position;
        ParticleSystem PS = BoomBoom.GetComponent<ParticleSystem>();
        explosionSFX.Play();
        PS.Play();
    }
}
