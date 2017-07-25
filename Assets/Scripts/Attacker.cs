using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range (0,2f)] public float WalkSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * WalkSpeed * Time.deltaTime);
	}
}
