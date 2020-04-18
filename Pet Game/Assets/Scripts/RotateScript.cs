using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{

    public string buttonKey;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(buttonKey))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }
}
