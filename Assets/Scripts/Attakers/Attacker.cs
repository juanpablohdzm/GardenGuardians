using UnityEngine;

public class Attacker : MonoBehaviour {

    private GameObject Enemy;
    private float CurrentSpeed;
    private Animator animator;
	// Use this for initialization
	void Start ()
    {
        Rigidbody2D RigidBody =gameObject.AddComponent<Rigidbody2D>();
        RigidBody.isKinematic = true;
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!Enemy)
            animator.SetBool("IsAttacking", false);
        transform.Translate(Vector2.left * CurrentSpeed * Time.deltaTime);
	}
    //Called at the animator at the time to move
    public void SetCurrentSpeed(float Speed)
    {
        CurrentSpeed = Speed;
    }

    // Called at the animator at the actual attack
    public void StrikeCurrentTarget(float Damage)
    {
        if(Enemy)
        Enemy.GetComponent<Health>().DealDamage(Damage);
    }
    public void Attack(GameObject CollisionObject)
    {
        Enemy = CollisionObject;
        
    }

}
