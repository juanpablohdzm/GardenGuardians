using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range (0,2f)] public float CurrentSpeed;
	// Use this for initialization
	void Start ()
    {
        Rigidbody2D RigidBody =gameObject.AddComponent<Rigidbody2D>();
        RigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.left * CurrentSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
    }

    public void SetCurrentSpeed(float Speed)
    {
        CurrentSpeed = Speed;
    }

    public void StrikeCurrentTarget(float Damage)
    {

    }
}
