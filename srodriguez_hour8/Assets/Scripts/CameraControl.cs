using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // float horizontalValue = Input.GetAxis("Horizontal");
       // float verticalValue = Input.GetAxis("Vertical");

        /* if (horizontalValue !=0)
        {
            Debug.Log("horizontal movement: " + horizontalValue);
        }

        if (verticalValue != 0)
        {
            Debug.Log("vertical movement: " + verticalValue); */

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("The A key is being pressed");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("The Z key is being pressed");
        }
    }

    }
