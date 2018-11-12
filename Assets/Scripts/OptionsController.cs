using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class OptionsController : MonoBehaviour {

    public Slider VolumeSlider;
    public Slider DifficultySlider;
    public Dropdown dropdownResultions;

    public float DefaultVolumeValue;
    public float DefaultDifficultyLevel;

    private MusicManager musicManager;
    private Resolution[] screenResolution;
    private bool bIsFullScreen=true;

	// Use this for initialization
	private void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetLevelDifficulty();

        screenResolution = Screen.resolutions;
        List<string> resolutions = new List<string>();
        int index = 0;
        dropdownResultions.ClearOptions();
        for (int i = 0; i < screenResolution.Length; i++)
        {
            resolutions.Add(screenResolution[i].ToString());
            if (screenResolution[i].width == Screen.currentResolution.width && screenResolution[i].height == Screen.currentResolution.height)
                index = i;

        }
        dropdownResultions.AddOptions(resolutions);
        dropdownResultions.value = index;
	}

    private void Update()
    {
        musicManager.ChangeVolume(VolumeSlider.value);
    }

    public void SafeAndExit()
    {

        PlayerPrefsManager.SetLevelDifficulty(DifficultySlider.value);
    }

    public void Defaults()
    {
        OnChangeVolume(DefaultVolumeValue);
        DifficultySlider.value = DefaultDifficultyLevel;
    }

    public void OnChangeVolume(float value)
    {
        PlayerPrefsManager.SetMasterVolume(value);
    }

    public void OnFullScreenChanged()
    {
        bIsFullScreen = !bIsFullScreen;
        Screen.fullScreen = bIsFullScreen;
    }

    public void OnScreenResolutionChanged(int index)
    {
        Screen.SetResolution(screenResolution[index].width, screenResolution[index].height, bIsFullScreen);
    }

    public void OnQualityChanged(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
