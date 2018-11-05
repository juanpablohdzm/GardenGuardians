
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameTimer : MonoBehaviour
{
    
    public float LevelTimeInSeconds;
    public LevelManager levelManager;
    public GameObject WinScreen;

    private AudioSource CompleteSound;
    private Slider slider;
    private bool IsEndOfLevel=false;

    private void Start()
    {
        slider = transform.GetComponent<Slider>();
        slider.maxValue = LevelTimeInSeconds;
        CompleteSound = GetComponent<AudioSource>();
        

    }

    private void Update()
    {
        slider.value += 1f * Time.deltaTime;
        if (slider.value == LevelTimeInSeconds && !IsEndOfLevel)
        {
            OnCompleteLevel();
            IsEndOfLevel = true;
        }
    }

    private void OnCompleteLevel()
    {
        AttackersSpawners.CanSpawn = false;
        CompleteSound.Play();
        WinScreen.SetActive(true);
        PlayerPrefsManager.SetUnlockLevel(SceneManager.GetActiveScene().buildIndex - 1);
        Invoke("NextLevel", CompleteSound.clip.length);
       
    }

    private void NextLevel()
    {
        levelManager.LoadNextLevel();
    }


}
