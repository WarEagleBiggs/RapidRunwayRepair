using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;
    
    //things to keep track of
    public bool isGamePlaying = true;
    public int highScore;
    public bool hasLevel2;
    public bool hasLevel3;
    public bool hasLevel4;
    public int level1Stars;
    public int level2Stars;
    public int level3Stars;
    public int level4Stars;
    public bool isLevel1;
    public bool isLevel2;
    public bool isLevel3;
    public bool isLevel4;


    public static Singleton GetInstance => instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
