using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public AudioClip SFXClip;
    public AudioClip BGMClip;

    public AudioSource SFXSource;
    public AudioSource BGMSource;

    private void Start()
    {
        BGMSource.clip = BGMClip;
        BGMSource.Play();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXSource.clip = SFXClip;
            SFXSource.Play();
        }

    }

}
