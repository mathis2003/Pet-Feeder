using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject losePanel;
    private bool hasAlreadyTouched;
    public GameObject soundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.CompareTag("Floor") && !hasAlreadyTouched)
        {
            losePanel.SetActive(true);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("FoodManager") && !hasAlreadyTouched)
        {
            collision.gameObject.GetComponent<FoodManager>().AddFood(1);
            Instantiate(soundPlayer, transform.position, Quaternion.identity);
            hasAlreadyTouched = true;


        }
	}
}
