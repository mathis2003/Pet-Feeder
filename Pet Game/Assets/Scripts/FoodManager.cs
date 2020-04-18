using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodManager : MonoBehaviour
{
    public int nextLVL; 
    public int totalFood;
    public GameObject winPanel;
    private int foodInCage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (foodInCage > totalFood)
        {
            WinLevel();
        }*/ 
    }

    public void AddFood (int foodIndex)
    {
        foodInCage += foodIndex;
        if (foodInCage >= totalFood)
        {
            WinLevel();
        } 
    }

    public void WinLevel()
    {
        if (nextLVL == 6)
        {
            SceneManager.LoadScene(nextLVL);
        }
        else 
        {
            if (PlayerPrefs.GetInt("lvlUnlocked") < nextLVL) PlayerPrefs.SetInt("lvlUnlocked", nextLVL);
            winPanel.SetActive(true);
        }

    }
}
