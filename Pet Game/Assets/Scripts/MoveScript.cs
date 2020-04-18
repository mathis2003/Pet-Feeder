using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public string leftButton;
    public string rightButton;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftButton)) transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(rightButton)) transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
