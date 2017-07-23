using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
    public AudioClip[] LevelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = LevelMusicChangeArray[0];
        audioSource.Play();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip ThisLevelClip = LevelMusicChangeArray[level];
        if (ThisLevelClip != null)
        {
            audioSource.clip = ThisLevelClip;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
