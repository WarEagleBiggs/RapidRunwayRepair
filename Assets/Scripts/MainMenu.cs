using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public GameObject LevelSelect;

    public GameObject Menu;
    public GameObject Tutorial;

    public bool isLvl2Unlocked;
    public bool isLvl3Unlocked;
    public bool isLvl4Unlocked;
    public List<GameObject> LockList;
    public AudioSource clickSfx;
    
    private void Update()
    {
        isLvl2Unlocked = Singleton.GetInstance.hasLevel2;
        
        if (isLvl2Unlocked)
        {
            LockList[0].SetActive(false);
        }

        if (isLvl3Unlocked)
        {
            LockList[1].SetActive(false);
        }

        if (isLvl4Unlocked)
        {
            LockList[2].SetActive(false);
        }
    }

    public void ToMenu()
    {
        clickSfx.Play();
        LevelSelect.SetActive(false);
        Tutorial.SetActive(false);
        Menu.SetActive(true);
    }
    public void ToLevelSelect()
    {
        clickSfx.Play();
        Menu.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void ToTutorial()
    {
        clickSfx.Play();
        Menu.SetActive(false);
        Tutorial.SetActive(true);
    }

    public void ToLevel1()
    {        
        clickSfx.Play();
        SceneManager.LoadScene(1);
    }
    public void ToLevel2()
    {
        if (isLvl2Unlocked)
        {
            clickSfx.Play();
            SceneManager.LoadScene(1);
        }
    }
    public void ToLevel3()
    {
        if (isLvl3Unlocked)
        {
            clickSfx.Play();
            SceneManager.LoadScene(1);
        }
    }
    public void ToLevel4()
    {
        if (isLvl4Unlocked)
        {
            clickSfx.Play();
            SceneManager.LoadScene(1);
        }
    }

}
