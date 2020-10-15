using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChara : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation=Quaternion.Euler(25,0,0);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.identity;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(-25, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.identity;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.identity;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0,30);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.identity;

        }

    }
}
