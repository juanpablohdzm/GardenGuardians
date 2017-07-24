using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour {

    public float FadeInTime;
	// Use this for initialization
	void Start ()
    {
        GetComponent<Image>().CrossFadeAlpha(0, FadeInTime, true);
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad >= FadeInTime)
            gameObject.SetActive(false);
    }
}
