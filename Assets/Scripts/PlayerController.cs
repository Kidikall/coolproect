using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed); }
    }
}
