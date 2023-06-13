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
    public TextMeshProUGUI planeTxt;

    public bool hasHappened;

    public List<GameObject> planeList;

    public AudioSource clickSfx;
    public bool isStar1Alive = true;
    public bool isStar2Alive = true;
    public bool isStar3Alive = true;
    public List<GameObject> Stars;
    public List<GameObject> GrayStars;
    public GameObject FailScreen;
    public GameObject HmBtn;
    public GameObject WinScreen;
    public bool isPlaying = true;
    public int planeCount = 10;
    public int starCount = 3;
    private void Start()
    {
        timer = duration;
    }


    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
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
            planeTxt.SetText(planeCount.ToString());
        }

        if (planeCount <= 0)
        {
            isPlaying = false;

            if (isPlaying == false && isStar1Alive)
            {
                WinScreen.SetActive(true);
                HmBtn.SetActive(false);
                if (Singleton.GetInstance.level1Stars < starCount)
                {
                    Singleton.GetInstance.level1Stars = starCount;
                }

                if (starCount >= 2)
                {
                    Singleton.GetInstance.hasLevel2 = true;
                }
            }
        }
    }



    public GameObject objectToInstantiate;  

    public void Spawn()
    {
        
        GameObject obj = Instantiate(objectToInstantiate);
        obj.SetActive(true);
        
    }

    public void Skip()
    {
        if (isPlaying)
        {

            clickSfx.Play();

            if (hasHappened == false)
            {
                hasHappened = true;
                timer = 0;
                Spawn();


            }
        }

    }

    public void HomeBtn()
    {    
        clickSfx.Play();
        SceneManager.LoadScene("Menu");
        
    }
    public void LoseStar()
    {
        starCount--;
        if (isStar3Alive)
        {
            Stars[2].SetActive(false);
            GrayStars[2].SetActive(true);
            isStar3Alive = false;
        }
        else if (isStar2Alive)
        {
            Stars[1].SetActive(false);
            GrayStars[1].SetActive(true);
            isStar2Alive = false;
        }
        else
        {
            Stars[0].SetActive(false);
            GrayStars[0].SetActive(true);
            isStar1Alive = false;
            isPlaying = false;
            FailScreen.SetActive(true);
            HmBtn.SetActive(false);
        }

    }
    

    public void Replay()
    {
        clickSfx.Play();
        SceneManager.LoadScene(1);
    }

  
}
