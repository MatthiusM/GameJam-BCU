using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 5f;
    Audio audio;
    
    void Start()
    {
        audio = GetComponent<Audio>();
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
            audio.PlaySound("FootSteps");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
            audio.PlaySound("FootSteps");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);
            audio.PlaySound("FootSteps");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, movementSpeed * Time.deltaTime, 0);
            audio.PlaySound("FootSteps");
        }
    }

}
