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
