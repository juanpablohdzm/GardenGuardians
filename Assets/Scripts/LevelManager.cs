using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public float AutoLoadLevelTime;

    private void Start()
    {
        //Delay for splash screen
        if(AutoLoadLevelTime>0)
        Invoke("LoadNextLevel", AutoLoadLevelTime);
        AttackersSpawners.CanSpawn = true;
       
    }
    public void LoadLevel(string name)
    { 
		SceneManager.LoadScene (name);
	}

	public void QuitRequest()
    {
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        int NextScene = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(NextScene);
       
    }

   

}
