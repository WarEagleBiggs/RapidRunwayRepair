using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Btn1Script : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void ToLevel()
    {
        SceneManager.LoadScene(sceneName);
    }
}
