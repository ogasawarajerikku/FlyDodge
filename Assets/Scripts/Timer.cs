using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public static float countTime = 0;
    public static float getcountTime()
    {
        return countTime;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");
    }
}