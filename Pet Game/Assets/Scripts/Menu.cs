using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void LoadLevelSelect ()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void LoadInfoScene ()
    {
        SceneManager.LoadScene("InfoScene");
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

   
}
