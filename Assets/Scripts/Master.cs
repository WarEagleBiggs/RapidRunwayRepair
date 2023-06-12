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
    public bool isStar1Alive = true;
    public bool isStar2Alive = true;
    public bool isStar3Alive = true;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;


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
    public void LoseStar()
    {
        if (isStar3Alive)
        {
            star3.SetActive(false);
            isStar3Alive = false;
        }
        else if (isStar2Alive)
        {
            star2.SetActive(false);
            isStar2Alive = false;
        }
        else if (isStar1Alive)
        {
            star1.SetActive(false);
            isStar1Alive = false;
        }
        else
        {
                
        }
    }
}
