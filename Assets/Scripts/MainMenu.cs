using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{   // different screens
    public GameObject LevelSelect;
    public GameObject Menu;
    public GameObject Tutorial;
    public GameObject Tut1;
    public GameObject Tut2;


    public GameObject Materials;
    public GameObject SoilInfo;
    public GameObject CementInfo;
    public GameObject AlumInfo;
    public GameObject SteelInfo;
    
    
    // bools controlling level locks
    public bool isLvl2Unlocked;
    public bool isLvl3Unlocked;
    public bool isLvl4Unlocked;
    // Lists of objects in level selection screen
    public List<GameObject> LockList;
    public List<GameObject> Lvl1Stars;
    public List<GameObject> Lvl2Stars;
    public List<GameObject> Lvl3Stars;
    public List<GameObject> Lvl4Stars;

    public AudioSource clickSfx;
    // ints tracking number of stars showing
    public List<int> StarsCounter;
    
    
    private void Update()
    {   // updates whether levels are locked
        isLvl2Unlocked = Singleton.GetInstance.hasLevel2;
        isLvl3Unlocked = Singleton.GetInstance.hasLevel3;
        isLvl4Unlocked = Singleton.GetInstance.hasLevel4;

        
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
    {   // turns off level select 
        // turns on menu screen
        clickSfx.Play();
        LevelSelect.SetActive(false);
        Tutorial.SetActive(false);
        Materials.SetActive(false);
        Menu.SetActive(true);
    }
    public void ToLevelSelect()
    {   // turns off  menu
        //turns on level select screen
        clickSfx.Play();
        // updates level1's stars whenever we go to level select screen
        if (StarsCounter[0] != Singleton.GetInstance.level1Stars)
        {
            StarsCounter[0] = Singleton.GetInstance.level1Stars;
            UpdateStars(Lvl1Stars, StarsCounter[0]);
        }
        //
        if (StarsCounter[1] != Singleton.GetInstance.level2Stars)
        {
            StarsCounter[1] = Singleton.GetInstance.level2Stars;
            UpdateStars(Lvl2Stars, StarsCounter[1]);
        }
        if (StarsCounter[2] != Singleton.GetInstance.level3Stars)
        {
            StarsCounter[2] = Singleton.GetInstance.level3Stars;
            UpdateStars(Lvl3Stars, StarsCounter[2]);
        }
        if (StarsCounter[3] != Singleton.GetInstance.level4Stars)
        {
            StarsCounter[3] = Singleton.GetInstance.level4Stars;
            UpdateStars(Lvl4Stars, StarsCounter[3]);
        }
        Menu.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void ToTutorial()
    {
        clickSfx.Play();
        Menu.SetActive(false);
        Tutorial.SetActive(true);
        Tut1.SetActive(true);
        Tut2.SetActive(false);
    }

    public void Tut1Next()
    {
        Tut1.SetActive(false);
        Tut2.SetActive(true);
    }

    public void Tut2Prev()
    {
        Tut2.SetActive(false);
        Tut1.SetActive(true);
    }
    

    public void ToMaterials()
    {
        clickSfx.Play();
        SoilInfo.SetActive(false);
        CementInfo.SetActive(false);
        AlumInfo.SetActive(false);
        SteelInfo.SetActive(false);
        Menu.SetActive(false);
        Materials.SetActive(true);
    }

    public void ToSoil()
    {
        clickSfx.Play();
        Materials.SetActive(false);
        SoilInfo.SetActive(true);
    }
    public void ToCement()
    {
        clickSfx.Play();
        Materials.SetActive(false);
        CementInfo.SetActive(true);
    }
    public void ToAlum()
    {
        clickSfx.Play();
        Materials.SetActive(false);
        AlumInfo.SetActive(true);
    }
    public void ToSteel()
    {
        clickSfx.Play();
        Materials.SetActive(false);
        SteelInfo.SetActive(true);
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
    // updates the level's stars when called
    public void UpdateStars(List<GameObject> stars, int starCount)
    {
        if (starCount == 1)
        {
            stars[0].SetActive(true);
        }
        else if (starCount == 2)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
}
