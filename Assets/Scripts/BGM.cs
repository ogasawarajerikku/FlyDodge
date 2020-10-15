using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{

    public AudioClip BackGroundMusic;
    private AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(BackGroundMusic);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
