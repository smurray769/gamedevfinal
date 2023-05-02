using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    //resolution
    
    //volume (i could have done this better but i'm not gonna redo it now)
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
