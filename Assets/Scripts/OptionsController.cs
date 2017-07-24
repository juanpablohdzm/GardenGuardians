using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider VolumeSlider;
    public Slider DifficultySlider;

    public float DefaultVolumeValue;
    public float DefaultDifficultyLevel;

    private MusicManager musicManager;
	// Use this for initialization
	private void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetLevelDifficulty();
	}

    private void Update()
    {
        musicManager.ChangeVolume(VolumeSlider.value);
    }

    public void SafeAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetLevelDifficulty(DifficultySlider.value);
    }

    public void Defaults()
    {
        VolumeSlider.value = DefaultVolumeValue;
        DifficultySlider.value = DefaultDifficultyLevel;
    }
}
