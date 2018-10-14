
using UnityEngine;
using UnityEngine.UI;

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
        print(CompleteSound.clip.length);
        Invoke("NextLevel", CompleteSound.clip.length);
       
    }

    private void NextLevel()
    {
        levelManager.LoadNextLevel();
    }


}
