using UnityEngine;

public class Defenders : MonoBehaviour {

    private StarDisplay starDisplay;
    public int StarCost = 100;

    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }
    public void AddStars(int stars)
    {
        starDisplay.AddStars(stars);
    }
    public void Update()
    {
        if (!AttackersSpawners.CanSpawn)
            Destroy(gameObject);
    }

}
