using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelUnlocker : MonoBehaviour {

    [SerializeField] private GameObject []levels;


	// Use this for initialization
	void Start () {
        for (int i = 1; i < levels.Length; i++)
        {
            if (PlayerPrefsManager.GetUnlockLevel(i))
            {
                levels[i].GetComponent<RawImage>().color = Color.white;
                levels[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                levels[i].GetComponent<RawImage>().color = Color.black;
                levels[i].GetComponent<Button>().interactable = false;
            }
            
        }
	}
}
