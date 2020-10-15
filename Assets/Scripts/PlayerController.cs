using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void Start()
    {
        
    }
    [SerializeField] public  float speed = 10;
    [SerializeField] public float upspeed = 100;
    [SerializeField] public float downspeed = 10;
    private void FixedUpdate()
    {

        //入力をxとzに代入
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.position += transform.up * upspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.up * downspeed * Time.deltaTime;
        }
    }
}
