using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public int nextLVL; 
    public int totalFood;
    public GameObject winPanel;
    public int foodInCage;
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
        PlayerPrefs.SetInt("lvlUnlocked", nextLVL);
        winPanel.SetActive(true);
    }
}
