using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Master : MonoBehaviour
{
    public float duration = 5f;  // Duration of the timer in seconds

    public float timer;

    public SpawnPlane SpawnScript;


    public TextMeshProUGUI numTxt;

    private void Start()
    {
        timer = duration;
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnScript.Spawn();
            // Reset the timer for the next cycle
            timer = duration;
        }
        
        
        numTxt.SetText(timer.ToString("#0") + " SEC");
    }

    public void Skip()
    {
        SpawnScript.Spawn();
        timer = 0;
    }
}
