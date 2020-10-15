using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject WinnerLabelObject;
    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString ();

        if (count == 0)
        {
            SceneManager.LoadScene("End");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {

            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
