using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Master : MonoBehaviour
{
    public float duration;

    public float timer;

    public TextMeshProUGUI numTxt;

    public bool hasHappened;

    public List<GameObject> planeList;

    public AudioSource clickSfx;

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
            // Reset the timer for the next cycle
            timer = duration;
            
            if (hasHappened)
            {
                hasHappened = false;
            }
            else
            {
                Skip();
            }
            
        }
        
        
        numTxt.SetText(timer.ToString("#0") + " SEC");
    }

    
    
    public GameObject objectToInstantiate;  

    public void Spawn()
    {
        
        GameObject obj = Instantiate(objectToInstantiate);
        obj.SetActive(true);
        
    }

    public void Skip()
    {
        clickSfx.Play();

        if (hasHappened == false)
        {
            hasHappened = true;
            timer = 0;
            Spawn();
            
        }
        
       
    }

    public void HomeBtn()
    {    
        clickSfx.Play();
        SceneManager.LoadScene("Menu");
        
    }
}
