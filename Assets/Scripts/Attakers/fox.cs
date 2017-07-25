using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class fox : MonoBehaviour {

    private Animator  animator;
    private Attacker attacker;

	// Use this for initialization
	void Start () {
        animator=gameObject.GetComponent<Animator>();
        attacker = gameObject.GetComponent<Attacker>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.GetComponent<Defenders>())
            return;

        if(collision.gameObject.GetComponent<Stone>())
        {
            animator.SetTrigger("JumpTrigger");
        }
        else
        {
            animator.SetBool("IsAttacking", true);
            attacker.Attack(collision.gameObject);
        }
    }
}
