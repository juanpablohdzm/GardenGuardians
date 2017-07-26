using UnityEngine;

public class Defenders : MonoBehaviour {

    private StarDisplay starDisplay;

    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }
    public void AddStars(int stars)
    {
        starDisplay.AddStars(stars);
    }

   
}
