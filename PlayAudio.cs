using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayAudio : MonoBehaviour
{

    public AudioSource pistol;
    public AudioSource pistolShell;

    int time = 0;
    // Use this for initialization
    void Start()
    {
        pistol = GetComponent<AudioSource>();
        pistolShell = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (time > 1.0f * Time.deltaTime)
            {
            pistol.Play();
                Audio1();
            }
        }
    }

    public void Audio1()
    {
            pistolShell.clip = Resources.Load<AudioClip>("PistolShell");
            pistolShell.Play();
    }
}
