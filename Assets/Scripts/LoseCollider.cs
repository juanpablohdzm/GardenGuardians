
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("Lose");
    }
}
