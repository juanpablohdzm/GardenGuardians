﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public float AutoLoadLevelTime;

    private void Start()
    {
        FindObjectOfType<MusicManager>().PlayTrack(SceneManager.GetActiveScene().buildIndex);
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

    public void StopTime(bool shouldStop)
    {
        if (shouldStop)
        {
            Time.timeScale = 0;
            MyButton.selected = null;
            MyButton.SelectDefender = null;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

   

}
