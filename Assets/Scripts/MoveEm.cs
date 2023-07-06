using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEm : MonoBehaviour
{
    public GameObject BoomBoom;


    public void MoveEmNow(Transform pos)
    {
        BoomBoom.transform.position = pos.transform.position;
        ParticleSystem PS = BoomBoom.GetComponent<ParticleSystem>();
        PS.Play();
    }
}
