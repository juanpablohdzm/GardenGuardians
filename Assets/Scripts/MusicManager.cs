using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
    public AudioClip[] LevelMusicChangeArray;

    private AudioSource audioSource;
    private AudioClip PreviousClip;
    private AudioClip ThisLevelClip;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    private void Start()
    {

        ThisLevelClip = LevelMusicChangeArray[SceneManager.GetActiveScene().buildIndex];
        if (ThisLevelClip != null && ThisLevelClip != PreviousClip)
        {
            PreviousClip = ThisLevelClip;
            audioSource.clip = ThisLevelClip;
            audioSource.loop = true;
            audioSource.Play();
            //Fix problem starting game without going to options to change volume 
            if (PlayerPrefsManager.GetMasterVolume() != 0)
                audioSource.volume = PlayerPrefsManager.GetMasterVolume();
        }

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = LevelMusicChangeArray[0];
        audioSource.Play();
    }

 

    public void ChangeVolume(float Volume)
    {
        audioSource.volume = Volume;
    }
}
