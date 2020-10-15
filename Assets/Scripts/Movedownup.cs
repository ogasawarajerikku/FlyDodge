using UnityEngine;

public class Movedownup : MonoBehaviour
{
    bool yPlus = false;//yが マイナス方向に移動中か
    [SerializeField]float tatespeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (yPlus == true)
        {
            transform.position += new Vector3(0f, tatespeed * Time.deltaTime, 0f);
            if (transform.position.y >= 10)
                yPlus = false;
        }
        else
        {
            transform.position -= new Vector3(0f, tatespeed * Time.deltaTime, 0f);
            if (transform.position.y <= -10)
                yPlus = true;
        }
    }
}