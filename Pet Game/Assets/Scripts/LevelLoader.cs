using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string nextLevel;
    public string thisLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void LoadThisLevel ()
    {
        SceneManager.LoadScene(thisLevel);
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoBack ()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
