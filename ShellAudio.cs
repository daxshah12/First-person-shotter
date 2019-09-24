using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellAudio : MonoBehaviour {

    public AudioSource shellAudio;
    float time = 0;

    // Use this for initialization
    void Start ()
    {
        shellAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
        {
            if (time > 150.0f * Time.deltaTime)
                time++;
                shellAudio.Play();
        }
        
    }
}
