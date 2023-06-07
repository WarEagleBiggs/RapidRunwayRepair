using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Master : MonoBehaviour
{
    public float duration = 5f;  // Duration of the timer in seconds

    private float timer;


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
            // Timer has ended, perform desired actions here
            Debug.Log("Timer ended!");

            // Reset the timer for the next cycle
            timer = duration;
        }
        
        
        numTxt.SetText(timer.ToString("#0") + " SEC");
    }
}
