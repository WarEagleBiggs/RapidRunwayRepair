using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtnScript : MonoBehaviour
{
    public GameObject LevelSelect;

    public GameObject Menu;
    // Start is called before the first frame update
    public void ToMenu()
    {
        LevelSelect.SetActive(false);
        Menu.SetActive(true);
    }
    
}
