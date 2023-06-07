using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlane : MonoBehaviour
{
    public GameObject objectToInstantiate;  // Prefab to instantiate
    public Transform spawnPoint;            // Position to spawn the object
    public float spawnInterval = 15f;       // Time interval between spawns

    private float elapsedTime;

    private void Start()
    {
        elapsedTime = 0f;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnInterval)
        {
            GameObject obj = Instantiate(objectToInstantiate);
            obj.SetActive(true);
            elapsedTime = 0f;
        }
    }
}
