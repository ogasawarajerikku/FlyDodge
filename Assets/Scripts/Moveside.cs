using UnityEngine;

public class Moveside : MonoBehaviour
{
    bool xPlus = true;//xがプラス方向に移動中か
    [SerializeField]float yokospeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (xPlus == true)
        {
            transform.position += new Vector3(yokospeed * Time.deltaTime, 0f, 0f);
            if (transform.position.x >= 10)
                xPlus = false;
        }
        else 
        {
            transform.position -= new Vector3(yokospeed * Time.deltaTime, 0f, 0f);
            if (transform.position.x <= -10)
                xPlus = true;
        }
    }
}
