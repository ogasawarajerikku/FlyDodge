using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeout : MonoBehaviour
{
    void Start()
    {
        float finaltime = Timer.getcountTime();
    // Start is called before the first frame update

        GetComponent<Text>().text = finaltime.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
