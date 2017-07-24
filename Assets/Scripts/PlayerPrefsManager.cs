using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY="master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_UNLOCKED_KEY = "level_unlocked_";

 


    public static void SetMasterVolume(float Volume)
    {
        if (Volume >= 0 && Volume <= 1f)
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, Volume);
        else
            Debug.LogWarning("Volume range not available");
    }

    public static float GetMasterVolume()
    {
       return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetUnlockLevel(int level)
    {
        if (level <= SceneManager.sceneCount - 1)
            PlayerPrefs.SetInt(LEVEL_UNLOCKED_KEY + level, 1);// 1 used as bool
        else
            Debug.LogWarning("Level not in build manager");
    }

    public static bool GetUnlockLevel(int level)
    {
        if(level <= SceneManager.sceneCount - 1)
            if (PlayerPrefs.GetInt(LEVEL_UNLOCKED_KEY + level) == 1)
                return true;
            else
                Debug.LogWarning("Level  locked");
        else
            Debug.LogWarning("Level  not exist");
        return false;
    }

    public static void SetLevelDifficulty(float difficulty)
    {
        if(difficulty >=1f && difficulty <= 3f)
        PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
    }

    public static float GetLevelDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
