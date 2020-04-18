using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChecker : MonoBehaviour
{
    public int lvl;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("lvlUnlocked", 0) >= lvl) panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel ()
    {
        SceneManager.LoadScene(lvl);
    }
}
