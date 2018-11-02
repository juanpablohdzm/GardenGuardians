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
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
       
        ThisLevelClip = LevelMusicChangeArray[0];
        PreviousClip = ThisLevelClip;
        audioSource.clip = ThisLevelClip;
        audioSource.loop = false;
        //Fix problem starting game without going to options to change volume 
        if (PlayerPrefsManager.GetMasterVolume() != 0)
            audioSource.volume = PlayerPrefsManager.GetMasterVolume();
        
        audioSource.Play();

    }

    public void PlayTrack(int SceneTrack)
    {
        ThisLevelClip = LevelMusicChangeArray[SceneTrack];
        if (ThisLevelClip != null && ThisLevelClip != PreviousClip)
        {
            PreviousClip = ThisLevelClip;
            audioSource.clip = ThisLevelClip;
            audioSource.loop = true;
            audioSource.Play();
        }

    }

    public void ChangeVolume(float Volume)
    {
        audioSource.volume = Volume;
    }
}
