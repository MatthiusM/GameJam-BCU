using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 5f;
    
    void Start()
    {
        
    }

    private void Update()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, movementSpeed * Time.deltaTime, 0);
        }
    }
}
