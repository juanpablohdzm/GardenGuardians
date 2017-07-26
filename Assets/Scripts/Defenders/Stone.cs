using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator animator;
    private Collider2D Enemy;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Attacker>())
        {
            animator.SetTrigger("Attack");
            Enemy = collision;
        }

    }
   
    public void StoneDamage(float Damage)
    {
        if(Enemy)
        {
            Enemy.GetComponent<Health>().DealDamage(Damage);
        }
    }
}
