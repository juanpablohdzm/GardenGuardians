using UnityEngine;

public class Lizard : MonoBehaviour {

    private Attacker attack;
    private Animator animator;
	// Use this for initialization
	void Start ()
    {
        animator = gameObject.GetComponent<Animator>();
        attack = gameObject.GetComponent<Attacker>();

    }
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.GetComponent<Defenders>())
            return;
        animator.SetBool("IsAttacking", true);
        attack.Attack(collision.gameObject);
    }
}
