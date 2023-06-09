using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonScript : MonoBehaviour
{
 public GameObject Menu;
 public GameObject LevelSelect;
 public void ToLevelSelect()
 {
  Menu.SetActive(false);
  LevelSelect.SetActive(true);
 }
}
