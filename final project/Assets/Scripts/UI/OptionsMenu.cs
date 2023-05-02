using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    //resolution
    
    //volume
    public AudioMixer audioMixer;

    public void SetMasterVolume(float newVolume)
    {
        audioMixer.SetFloat("MasterVolume", newVolume);
    }

    public void SetAtmosphereVolume(float newVolume)
    {
        audioMixer.SetFloat("AtmosphereVolume", newVolume);
    }

    public void SetMusicVolume(float newVolume)
    {
        audioMixer.SetFloat("MusicVolume", newVolume);
    }

    public void SetSFXVolume(float newVolume)
    {
        audioMixer.SetFloat("SFXVolume", newVolume);
    }

    //back button
    public void GoBack()
    {
        this.gameObject.SetActive(false);
    }
}
