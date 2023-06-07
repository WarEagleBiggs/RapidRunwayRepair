using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlane : MonoBehaviour
{
    public GameObject objectToInstantiate;  // Prefab to instantiate
    public Transform spawnPoint;
    public Master masterScript;


    public void Spawn()
    {
        GameObject obj = Instantiate(objectToInstantiate);
        obj.SetActive(true);
    }
}
