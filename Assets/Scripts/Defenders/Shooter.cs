using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject Projectile;

    private Animator animator;
    private static GameObject ProjectileParent;
    private AttackersSpawners SpawnLane;
    
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        ProjectileParent = GameObject.Find("Projectiles");
        if(ProjectileParent==null)
        ProjectileParent = new GameObject("Projectiles");
        SetSpawnLane();
    }

    private void Update()
    {
      
        if (IsAttackerAheadInLane())
            animator.SetBool("IsAttacking", true);
        else
            animator.SetBool("IsAttacking", false);
    }

    private void SetSpawnLane()
    {
        AttackersSpawners[] Lane = GameObject.FindObjectsOfType<AttackersSpawners>();
        for (int i = 0; i < Lane.Length; i++)
        {

            if (Lane[i].transform.position.y == gameObject.transform.position.y)
            {
                SpawnLane = Lane[i];
                return;
            }
        }
    }

    private bool IsAttackerAheadInLane()
    {
        if (SpawnLane.transform.childCount <= 0)
            return false;
        foreach (Transform attackers in SpawnLane.transform)
        {
            if (attackers.transform.position.x > transform.position.x)
                return true;
        }
        return false;
    }

    private void Fire()
    {
        GameObject ProjectileClone = Instantiate(Projectile, transform.Find("Gun").transform.position, Quaternion.identity, ProjectileParent.transform);
    }
}
