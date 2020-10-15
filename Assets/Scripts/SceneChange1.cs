using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stage01");
        }
    }
}
