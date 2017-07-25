using UnityEngine;

public class projectile : MonoBehaviour {

    public float Speed=1f;
    public float Damage=10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
	}
}
